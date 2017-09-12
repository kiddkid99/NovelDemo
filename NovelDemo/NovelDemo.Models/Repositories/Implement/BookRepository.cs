using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovelDemo.Models.Repositories.Interface;
using NovelDemo.Models.Repositories.Implement;
using NovelDemo.Models.Entity;
using Dapper;
using DapperExtensions;

namespace NovelDemo.Models.Repositories.Implement
{
    public class BookRepository : DapperGenericRepository<Book>, IBookRepository
    {
        public BookRepository(IDbConnectionFactory dbConnectionFactory) : base(dbConnectionFactory)
        {

        }

        public Book Get(int id)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                return conn.Get<Book>(id);
            }
        }

        public IEnumerable<Book> GetAllDetail()
        {
            using (var conn = DbConnectionFactory.Create())
            {
                string sql = 
                    @"SELECT * FROM #Book b
                      LEFT JOIN #Author a ON b.AuthorId = a.Id
                      LEFT JOIN #Category c ON b.CategoryId = c.Id
                      ORDER BY b.Id";

                var data = conn.Query<Book, Author, Category, Book>(sql, 
                    (book, author, category) =>
                {
                    book.Author = author;
                    book.Category = category;
                    return book;
                });

                return data;
            }
        }
    }
}
