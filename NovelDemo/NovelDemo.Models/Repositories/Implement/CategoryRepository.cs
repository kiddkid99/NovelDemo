using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovelDemo.Models.Repositories.Interface;
using NovelDemo.Models.Repositories.Implement;
using NovelDemo.Models.Entity;
using DapperExtensions;

namespace NovelDemo.Models.Repositories.Implement
{
    public class CategoryRepository : DapperGenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbConnectionFactory dbConnectionFactory) : base(dbConnectionFactory)
        {

        }

        public Category Get(int id)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                return conn.Get<Category>(id);
            }
        }
    }
}
