using System.Collections.Generic;

namespace NovelDemo.Models.Entity
{
    public partial class Author
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
