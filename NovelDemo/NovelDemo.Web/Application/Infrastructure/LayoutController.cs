using NovelDemo.Service.Interface;
using System.Web.Mvc;

namespace NovelDemo.Web.Application.Infrastructure
{
    public class LayoutController : Controller
    {
        protected IServices Services;

        public LayoutController(IServices services)
        {
            Services = services;
        }
    }
}