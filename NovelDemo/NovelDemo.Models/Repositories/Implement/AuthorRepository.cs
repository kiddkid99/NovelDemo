using DapperExtensions;
using NovelDemo.Models.Entity;
using NovelDemo.Models.Repositories.Interface;


namespace NovelDemo.Models.Repositories.Implement
{
    public class AuthorRepository : DapperGenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(IDbConnectionFactory dbConnectionFactory) : base(dbConnectionFactory)
        {
            
        }

        public Author Get(int id)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                return conn.Get<Author>(id);
            }
        }
    }
}
