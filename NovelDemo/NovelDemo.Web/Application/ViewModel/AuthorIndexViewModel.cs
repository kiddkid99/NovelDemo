using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovelDemo.Web.Application.ViewModel
{
    public class AuthorIndexViewModel
    {
        public IEnumerable<AuthorViewModel> Authors { get; set; }
    }
}