using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelDemo.Models.Entity
{
    public partial class Author
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
