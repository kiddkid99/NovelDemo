using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NovelDemo.Service.Interface;
using NovelDemo.Web.Application.Infrastructure;
using NovelDemo.Web.Application.ViewModel;

namespace NovelDemo.Web.Controllers
{
    public class AuthorController : LayoutController
    {
        public AuthorController(IServices services) : base(services)
        {
        }

        [HttpGet]
        public ActionResult Index()
        {
            var datas = Services.Author.GetAll();

            AuthorIndexViewModel model = new AuthorIndexViewModel
            {
                Authors = datas.Select(a => new AuthorViewModel
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Status = a.Status
                })
            };


            return View(model);
        }
    }
}