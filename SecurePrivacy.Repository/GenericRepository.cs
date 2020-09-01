using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using SecurePrivacy.Domain;

namespace SecurePrivacy.Repository
{
    public abstract class GenericRepository
    {
        private static List<Book> _bookStorage = new List<Book>();
        
        public virtual bool Create(Book model)
        {
            if (_bookStorage.FirstOrDefault(x => x.Id == model.Id) != null)
                return false;
            _bookStorage.Add(model);
            return true;
        }

        public virtual bool Update(Book model)
        {
            var book = _bookStorage.FirstOrDefault(x=> x.Id == model.Id);
            if (book == null)
            {
                return false;
            }
            _bookStorage.Remove(book);
            _bookStorage.Add(model);
            return true;
        }

        public virtual Book Read(int id)
        {
            _bookStorage.Add(new Book
            {
                Id=4,
                Author = "tekin",
                Title = "alp",
            });
            return _bookStorage.FirstOrDefault(x => x.Id == id);
        }

        public virtual bool Delete(int id)
        {
            var book = _bookStorage.FirstOrDefault(x => x.Id == id);
            if (book == null)
                return false;

            _bookStorage.Remove(book);
            return true;
        }
    }
}
