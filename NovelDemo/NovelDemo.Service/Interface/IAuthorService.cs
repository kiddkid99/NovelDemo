using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovelDemo.Models.Entity;

namespace NovelDemo.Service.Interface
{
    public interface IAuthorService
    {
        Author GetById(int id);

        IResult Insert(Author entity);

        IResult Update(Author entity);

        IResult Delete(Author entity);

        bool IsExist(int id);

        IEnumerable<Author> GetAll();
    }
}
