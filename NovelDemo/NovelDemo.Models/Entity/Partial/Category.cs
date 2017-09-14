using System.Collections.Generic;

namespace NovelDemo.Models.Entity
{
    public partial class Category
    { 
        public IEnumerable<Book> Books { get; set; }
    }
}
