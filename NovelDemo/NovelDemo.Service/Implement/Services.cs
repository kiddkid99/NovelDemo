using NovelDemo.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelDemo.Service.Implement
{
    public class Services : IServices
    {
        public IBookService Book { get; }

        public ICategoryService Category { get; }

        public IAuthorService Author { get; }


        public Services(IBookService book, ICategoryService category, IAuthorService author)
        {
            Book = book;
            Category = category;
            Author = author;
        }
    }
}
