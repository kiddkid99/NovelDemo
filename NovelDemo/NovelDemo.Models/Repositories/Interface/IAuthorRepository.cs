using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovelDemo.Models.Entity;

namespace NovelDemo.Models.Repositories.Interface
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        Author Get(int id);
    }
}
