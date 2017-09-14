using Dapper;
using DapperExtensions;
using NovelDemo.Models.Entity;
using NovelDemo.Models.Repositories.Interface;
using System.Collections.Generic;

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
                conn.Open();
                return conn.Get<Book>(id);
            }
        }

        public IEnumerable<Book> GetAllDetail()
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
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
