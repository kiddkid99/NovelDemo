using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelDemo.Models.Repositories.Interface
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
