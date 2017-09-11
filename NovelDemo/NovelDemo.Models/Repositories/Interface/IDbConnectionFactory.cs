using System.Data;

namespace NovelDemo.Models.Repositories.Interface
{
    public interface IDbConnectionFactory
    {
        IDbConnection Create();
    }
}