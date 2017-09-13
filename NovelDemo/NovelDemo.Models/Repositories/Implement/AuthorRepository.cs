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
