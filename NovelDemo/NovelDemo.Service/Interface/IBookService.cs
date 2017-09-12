using NovelDemo.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelDemo.Service.Interface
{
    public interface IBookService
    {
        IResult Insert(Book entity);

        IResult Update(Book entity);

        IResult Delete(Book entity);

        bool IsExist(int id);

        IEnumerable<Book> GetAll();
    }
}
