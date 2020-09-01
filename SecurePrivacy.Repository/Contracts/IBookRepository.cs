using System;
using System.Collections.Generic;
using System.Text;
using SecurePrivacy.Domain;

namespace SecurePrivacy.Repository.Contracts
{
    public interface IBookRepository : IRepository<Book>
    {
        bool CheckTheAuthorization(Guid key);
    }
}
