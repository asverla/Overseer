using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OverseerAPI.Data.Service;

namespace OverseerAPI.Data.Interface
{
    public class OverseerRepository : IRepository
    {
        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public T Find<T>(Func<T, bool> @where) where T : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
