using NovelDemo.Models.Entity;
using System.Collections.Generic;

namespace NovelDemo.Service.Interface
{
    public interface ICategoryService
    {
        Category GetById(int id);

        IResult Insert(Category entity);

        IResult Update(Category entity);

        IResult Delete(Category entity);

        bool IsExist(int id);

        IEnumerable<Category> GetAll();
    }
}
