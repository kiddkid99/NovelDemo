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

        public LayoutController()
        {
            //TODO: 直接實體化服務介面，之後需改成使用依賴注入的方式由外部決定介面實體
            string connectionString = ConfigurationManager.ConnectionStrings["NovelDemoDb"].ToString();
            IDbConnectionFactory dbConnectionFactory = new DatabaseConnectionFactory(connectionString);
            IBookService book = new BookService(new BookRepository(dbConnectionFactory));
            IAuthorService author = new AuthorService(new AuthorRepository(dbConnectionFactory));
            ICategoryService category = new CategoryService(new CategoryRepository(dbConnectionFactory));

            Services = new Services(book, category, author);
        }

        public LayoutController(IServices services)
        {
            Services = services;
        }
    }
}