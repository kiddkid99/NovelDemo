using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovelDemo.Web.Application.ViewModel
{
    public class AuthorDetailViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Status { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}