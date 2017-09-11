using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovelDemo.Models.Repositories.Interface;

namespace NovelDemo.Models.Test.Fake
{
    public class FakeGenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected List<T> data;

        public FakeGenericRepository()
        {
            data = new List<T>();
        }

        public void Delete(T entity)
        {
            data.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return data.ToList();
        }

        public void Insert(T entity)
        {
            data.Add(entity);
        }

        public void Update(T entity)
        {
            
        }
    }
}
