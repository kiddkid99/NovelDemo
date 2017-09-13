using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExtensions;
using NovelDemo.Models.Repositories.Interface;
using System.Data.Common;
using NovelDemo.Models.Entity.Mapping;

namespace NovelDemo.Models.Repositories.Implement
{
    public class DapperGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected IDbConnectionFactory DbConnectionFactory { get; }

        public DapperGenericRepository(IDbConnectionFactory dbConnectionFactory)
        {
            DapperCustomMapping.Mapping();
            DbConnectionFactory = dbConnectionFactory;
        }

        public IEnumerable<TEntity> GetAll()
        {
            using (var conn = this.DbConnectionFactory.Create())
            {
                conn.Open();
                var data =  conn.GetList<TEntity>();
                return data.ToList();
            }
        }

        public void Insert(TEntity entity)
        {
            using (var conn = this.DbConnectionFactory.Create())
            {
                conn.Open();
                conn.Insert(entity);
            }
        }

        public void Update(TEntity entity)
        {
            using (var conn = this.DbConnectionFactory.Create())
            {
                conn.Open();
                conn.Update(entity);
            }
        }

        public void Delete(TEntity entity)
        {
            using (var conn = this.DbConnectionFactory.Create())
            {
                conn.Open();
                conn.Delete(entity);
            }
        }


    }
}
