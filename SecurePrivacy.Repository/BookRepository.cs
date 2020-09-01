using System;
using System.Collections.Generic;
using System.Text;
using SecurePrivacy.Common.Constants;
using SecurePrivacy.Domain;
using SecurePrivacy.Repository.Contracts;

namespace SecurePrivacy.Repository
{
    public class BookRepository : GenericMongoRepository<Book>, IBookRepository
    {

        public BookRepository(IMongoDbSettings settings, string collectionName) : base(settings, collectionName)
        {
        }

        public bool CheckTheAuthorization(Guid key)
        {
            return AccessKey._accessKey.Equals(key);
        }
    }
}
