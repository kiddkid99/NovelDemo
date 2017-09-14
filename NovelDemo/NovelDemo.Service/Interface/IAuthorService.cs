using NovelDemo.Models.Entity;
using System.Collections.Generic;

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
