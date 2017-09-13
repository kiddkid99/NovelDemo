using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NovelDemo.Service.Interface;
using NovelDemo.Web.Application.Infrastructure;

namespace NovelDemo.Web.Controllers
{
    public class AuthorController : LayoutController
    {
        public AuthorController(IServices services) : base(services)
        {
        }

        // GET: Author
        public ActionResult Index()
        {
            return View();
        }
    }
}