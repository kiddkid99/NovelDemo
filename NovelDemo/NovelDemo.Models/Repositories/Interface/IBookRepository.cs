using NovelDemo.Models.Entity;
using System.Collections.Generic;

namespace NovelDemo.Models.Repositories.Interface
{
    public interface IBookRepository: IGenericRepository<Book>
    {
        Book Get(int id);

        IEnumerable<Book> GetAllDetail();
    }
}
