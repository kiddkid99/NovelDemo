using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NovelDemo.Service.Interface;
using NovelDemo.Service.Implement;
using NovelDemo.Models.Repositories.Implement;
using NovelDemo.Models.Repositories.Interface;
using System.Configuration;

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