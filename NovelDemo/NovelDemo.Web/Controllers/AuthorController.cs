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
    public class AuthorController : LayoutController
    {
        public AuthorController() : base()
        {

        }

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

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public ActionResult SubmitAdd(AuthorAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                Author data = new Author
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName
                };

                var result = Services.Author.Insert(data);
                if(result.Success)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.ErrorMessage = result.Exception != null ? result.Exception.Message : result.Message;
                    return View();
                }   
            }
            else
            {
                return View();
            }
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = Services.Author.GetById(id);

            if(data != null)
            {
                AuthorEditViewModel model = new AuthorEditViewModel
                {
                    Id = data.Id,
                    FirstName = data.FirstName,
                    LastName = data.LastName,
                    Status = data.Status == 1
                };

                return View(model);
            }
            else
            {
                ViewBag.ErrorMessage = "找不到資料";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult SubmitEdit(AuthorEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Author data = new Author
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Status = (byte)(model.Status ? 1 : 0)
                };

                var result = Services.Author.Update(data);
                if (result.Success)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.ErrorMessage = result.Exception != null ? result.Exception.Message : result.Message;
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}