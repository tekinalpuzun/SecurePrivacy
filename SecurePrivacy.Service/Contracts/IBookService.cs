using System;
using SecurePrivacy.Domain;
using SecurePrivacy.Domain.Dto;

namespace SecurePrivacy.Service.Contracts
{
    public interface IBookService
    {
        BookDto Create(BookDto book);
        void Update(string id, BookDto book);
        BookDto Read(string id);
        void Delete(string id);
        bool GetAuthorization(Guid key);
    }
}
