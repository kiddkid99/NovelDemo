using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovelDemo.Web.Application.ViewModel
{
    public class AuthorViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte Status { get; set; }
    }
}