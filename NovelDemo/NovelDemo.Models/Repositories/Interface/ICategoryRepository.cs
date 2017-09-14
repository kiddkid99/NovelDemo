using NovelDemo.Models.Entity;

namespace NovelDemo.Models.Repositories.Interface
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Category Get(int id);
    }
}
