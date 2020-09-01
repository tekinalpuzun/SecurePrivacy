using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SecurePrivacy.Domain
{
    public class Book : BaseMongoModel
    {
        [BsonElement("Author")]
        public string Author { get; set; }
        [BsonElement("Title")]
        public string Title { get; set; }
    }
}
