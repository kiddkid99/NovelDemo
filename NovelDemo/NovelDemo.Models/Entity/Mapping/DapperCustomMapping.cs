using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExtensions.Mapper;
using Dapper;

namespace NovelDemo.Models.Entity.Mapping
{
    public class DapperCustomMapping
    {
        public static void Mapping()
        {
            //Scan custom mapping under this Class
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new[] { typeof(DapperCustomMapping).Assembly });
        }

        public class AuthorMapping : ClassMapper<Author>
        {
            public AuthorMapping()
            {
                Map(e => e.Books).Ignore();
                AutoMap();
            }
        }

        public class BookMapping : ClassMapper<Book>
        {
            public BookMapping()
            {
                Map(e => e.Author).Ignore();
                Map(e => e.Category).Ignore();
                AutoMap();
            }
        }


        public class CategoryMapping : ClassMapper<Category>
        {
            public CategoryMapping()
            {
                Map(e => e.Books).Ignore();
                AutoMap();
            }
        }


    }
}
