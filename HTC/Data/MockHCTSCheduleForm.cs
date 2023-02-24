using HTC.Models;
using Repository;
using System.Linq.Expressions;

namespace HTC.Data
{
    public class MockHCTSCheduleForm
    {
        //public void Add(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public IQueryable<T> AsQueryable()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Attach(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<T> Find(Expression<Func<T, bool>> where)
        //{
        //    throw new NotImplementedException();
        //}

        //public T First(Expression<Func<T, bool>> where)
        //{
        //    throw new NotImplementedException();
        //}

        public List<HCTOrders> GetAll()
        {
            List<HCTOrders> list =new List<HCTOrders> {
                 new HCTOrders{ Name = "Dan Smith", DateOfBirth= "01/20/2000", Gender="Male", MRN="123456", Active= "Yes" },
                 new HCTOrders{ Name = "Redmond Reinhart", DateOfBirth= "01/10/2001", Gender="Male", MRN="124246", Active= "Yes" },
                 new HCTOrders{ Name = "Kyle hartman", DateOfBirth= "01/20/1960", Gender="Male", MRN="234554", Active= "Yes" },
                 new HCTOrders{ Name = "Naga Boyapati", DateOfBirth= "01/20/1995", Gender="Male", MRN="654321", Active= "Yes" },
                 new HCTOrders{ Name = "Oscar Mendez", DateOfBirth= "01/20/1980", Gender="Male", MRN="273849", Active= "Yes" }
            };

            return list;
        }

        //public void InsertOrUpdate(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public T Single(Expression<Func<T, bool>> where)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
