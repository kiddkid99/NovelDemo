using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NovelDemo.Service.Interface;
using NovelDemo.Web.Application.Infrastructure;
using NovelDemo.Web.Application.ViewModel;
using NovelDemo.Models.Entity;

namespace NovelDemo.Web.Controllers
{
    public class CategoryController : LayoutController
    {
        public CategoryController(IServices services) : base(services)
        {
        }

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
    }
}