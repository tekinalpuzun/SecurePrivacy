using System;
using System.Collections.Generic;
using System.Text;
using SecurePrivacy.Repository.Contracts;

namespace SecurePrivacy.Repository
{
    public class MongoDbSettings : IMongoDbSettings
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
    }
}
