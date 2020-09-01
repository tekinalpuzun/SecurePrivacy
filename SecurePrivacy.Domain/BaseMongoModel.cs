using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace SecurePrivacy.Domain
{
    public abstract class BaseMongoModel
    {
        public ObjectId Id { get; set; }
    }
}
