using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelDemo.Models.Entity
{
    public partial class Book
    {
        public int Id { get; set; }

        public int? AuthorId { get; set; }

        public int? CategoryId { get; set; }

        public string Title { get; set; }

        public byte Status { get; set; }

        public string ISBN { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }

    }
}
