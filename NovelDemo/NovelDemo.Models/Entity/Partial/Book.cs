using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelDemo.Models.Entity.Partial
{
    public partial class Book
    {
        public Author Author { get; set; }

        public Category Category { get; set; }
    }
}
