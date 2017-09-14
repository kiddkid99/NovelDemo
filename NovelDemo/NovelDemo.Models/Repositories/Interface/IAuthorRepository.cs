using NovelDemo.Models.Entity;

namespace NovelDemo.Models.Repositories.Interface
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        Author Get(int id);
    }
}
