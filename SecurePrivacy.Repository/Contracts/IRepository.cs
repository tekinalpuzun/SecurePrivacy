using System;
using System.Collections.Generic;
using System.Text;
using SecurePrivacy.Domain;

namespace SecurePrivacy.Repository.Contracts
{
    public interface IRepository<TModel>
        where TModel : BaseMongoModel
    {
        TModel Create(TModel model);
        void Update(string id, TModel model);
        TModel GetById(string id);
        void Delete(string id);
    }
}
