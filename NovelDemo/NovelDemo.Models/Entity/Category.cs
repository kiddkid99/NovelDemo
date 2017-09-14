using System;

namespace NovelDemo.Models.Entity
{
    public partial class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public byte Status { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
