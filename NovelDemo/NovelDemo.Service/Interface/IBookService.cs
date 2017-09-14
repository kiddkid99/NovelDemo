using NovelDemo.Models.Entity;
using System.Collections.Generic;

namespace NovelDemo.Service.Interface
{
    public interface IBookService
    {
        Book GetById(int id);

        IResult Insert(Book entity);

        IResult Update(Book entity);

        IResult Delete(Book entity);

        bool IsExist(int id);

        IEnumerable<Book> GetAll();
    }
}
