using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelDemo.Service.Interface
{
    public interface IService
    {
        IBookService Book { get; }

        ICategoryService Category { get; }

        IAuthorService Author { get; }
    }
}
