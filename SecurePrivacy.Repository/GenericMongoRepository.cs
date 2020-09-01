using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using SecurePrivacy.Domain;
using SecurePrivacy.Repository.Contracts;

namespace SecurePrivacy.Repository
{
    public class GenericMongoRepository<TModel>
        where TModel : BaseMongoModel
    {
        private readonly IMongoCollection<TModel> _mongoCollection;

        public GenericMongoRepository(IMongoDbSettings settings, string collectionName)
        {
            settings.ConnectionString =
                "mongodb+srv://admin:deneme123@cluster0.4jk2k.azure.mongodb.net/deneme?retryWrites=true&w=majority";
            settings.DatabaseName = "deneme";
            var database = new MongoClient(settings.ConnectionString).GetDatabase(settings.DatabaseName);
            _mongoCollection = database.GetCollection<TModel>(collectionName);
        }

        public virtual TModel GetById(string id)
        {
            var docId = new ObjectId(id);
            return _mongoCollection.Find<TModel>(m => m.Id == docId).FirstOrDefault();
        }
        public virtual TModel Create(TModel model)
        {
            _mongoCollection.InsertOne(model);
            return model;
        }

        public virtual void Update(string id, TModel model)
        {
            var docId = new ObjectId(id);
            _mongoCollection.ReplaceOne(m => m.Id == docId, model);
        }

        public virtual void Delete(TModel model)
        {
            _mongoCollection.DeleteOne(m => m.Id == model.Id);
        }

        public virtual void Delete(string id)
        {
            var docId = new ObjectId(id);
            _mongoCollection.DeleteOne(m => m.Id == docId);
        }
    }
}
