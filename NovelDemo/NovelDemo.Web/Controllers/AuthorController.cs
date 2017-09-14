using NovelDemo.Models.Entity;
using NovelDemo.Service.Interface;
using NovelDemo.Web.Application.Infrastructure;
using NovelDemo.Web.Application.ViewModel;
using System.Linq;
using System.Web.Mvc;

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
                if (result.Success)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData[TempDataKey.ErrorMessage] = result.Exception != null ? result.Exception.Message : result.Message;
                    return View();
                }
            }
            else
            {
                return View();
            }
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var data = id.HasValue ? Services.Author.GetById(id.Value) : null;

            if (data != null)
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
                TempData[TempDataKey.ErrorMessage] = "找不到資料";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult SubmitEdit(AuthorEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                //取出資料
                var data = Services.Author.GetById(model.Id) ?? new Author();

                //更新指定屬性
                data.FirstName = model.FirstName;
                data.LastName = model.LastName;
                data.Status = (byte)(model.Status ? 1 : 0);

                var result = Services.Author.Update(data);
                if (result.Success)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData[TempDataKey.ErrorMessage] = result.Exception != null ? result.Exception.Message : result.Message;
                    return View();
                }
            }
            else
            {
                return View();
            }
        }


        [HttpGet]
        public ActionResult Detail(int? id)
        {
            var data = id.HasValue ? Services.Author.GetById(id.Value) : null;

            if (data != null)
            {
                AuthorDetailViewModel model = new AuthorDetailViewModel
                {
                    Id = data.Id,
                    FirstName = data.FirstName,
                    LastName = data.LastName,
                    Status = data.Status == 1 ? "正常" : "停用",
                    CreateTime = data.CreateTime,
                    UpdateTime = data.UpdateTime

                };

                return View(model);
            }
            else
            {
                TempData[TempDataKey.ErrorMessage] = "找不到資料";
                return RedirectToAction("Index");
            }
        }


        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var data = id.HasValue ? Services.Author.GetById(id.Value) : null;

            if(data != null)
            {
                AuthorDetailViewModel model = new AuthorDetailViewModel
                {
                    Id = data.Id,
                    FirstName = data.FirstName,
                    LastName = data.LastName,
                    Status = data.Status == 1 ? "正常" : "停用",
                    CreateTime = data.CreateTime,
                    UpdateTime = data.UpdateTime

                };

                return View(model);
            }
            else
            {
                TempData[TempDataKey.ErrorMessage] = "找不到資料";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult SubmitDelete(int id)
        {
            Author data = new Author { Id = id };

            var result = Services.Author.Delete(data);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            else
            {
                TempData[TempDataKey.ErrorMessage] = result.Exception != null ? result.Exception.Message : result.Message;
                return View();
            }
        }
    }
}