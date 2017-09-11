using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovelDemo.Models.Entity;
using NovelDemo.Models.Repositories.Interface;

namespace NovelDemo.Models.Test.Fake
{
    public class FakeAuthorRepository : FakeGenericRepository<Author>, IAuthorRepository
    {
        public FakeAuthorRepository()
        {
            data = new List<Author>
            {
                new Author(){ Id = 1, CreateTime = DateTime.Now, Status = 1, FirstName = "Wang", LastName = "Kidd"  },
                new Author(){ Id = 2, CreateTime = DateTime.Now, Status = 1, FirstName = "God", LastName = "Gu" }
            };
        }

        public Author Get(int id)
        {
            return data.SingleOrDefault(a => a.Id == id);
        }
    }
}
