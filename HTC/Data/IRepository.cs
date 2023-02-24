using System;
using System.Collections.Generic;
using System.Linq;

using System.Linq.Expressions;

namespace Repository
{
    public interface IRepository<T> where T : class
        {
            IQueryable<T> AsQueryable();
            IEnumerable<T> GetAll();
            IEnumerable<T> Find(Expression<Func<T, bool>> where);
            T Single(Expression<Func<T, bool>> where);
            T First(Expression<Func<T, bool>> where);
            void InsertOrUpdate(T entity); 
            void Delete(T entity);
            void Add(T entity);
            void Attach(T entity);

    }

}
