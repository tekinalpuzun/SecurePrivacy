using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using SecurePrivacy.Domain;

namespace SecurePrivacy.Repository
{
    public abstract class GenericRepositoryUpdated<T> where T : class
    {
        private IQueryable<T> _bookStorage = Enumerable.Empty<T>().AsQueryable();
        private List<T> deneme = new List<T>();

        public virtual bool Create(T model)
        {
            deneme.Add(model);
            return true;
        }

        public virtual bool Update(T model, Expression<Func<T, bool>> filter)
        {
            var temp = deneme.AsQueryable();
            var book = temp.FirstOrDefault(filter);
            if (book == null)
            {
                return false;
            }
            deneme.Remove(book);
            deneme.Add(model);
            return true;
        }

        public virtual T Read(Expression<Func<T, bool>> filter)
        {
            var temp = deneme.AsQueryable();
            return temp.FirstOrDefault(filter);
        }

        public virtual bool Delete(Expression<Func<T, bool>> filter)
        {
            var temp = deneme.AsQueryable();
            var book = temp.FirstOrDefault(filter);

            if (book == null)
                return false;

            deneme.Remove(book);
            return true;
        }
    }
}
