using DapperExtensions;
using NovelDemo.Models.Entity;
using NovelDemo.Models.Repositories.Interface;

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
                conn.Open();
                return conn.Get<Category>(id);
            }
        }
    }
}
