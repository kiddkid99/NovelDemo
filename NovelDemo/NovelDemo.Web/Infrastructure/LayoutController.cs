using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NovelDemo.Service.Interface;

namespace NovelDemo.Web.Infrastructure
{
    public class LayoutController : Controller
    {
        protected readonly IServices Services;

        public LayoutController(IServices services)
        {
            Services = services;
        }
    }
}