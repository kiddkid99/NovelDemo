using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using NovelDemo.Models.Repositories.Implement;
using NovelDemo.Models.Repositories.Interface;
using NovelDemo.Service.Interface;
using NovelDemo.Service.Implement;
using System.Configuration;
using System.Reflection;

namespace NovelDemo.Web
{
    public class AutofacConfig
    {
        public static void Registration()
        {
            ContainerBuilder builder = new ContainerBuilder();

            //Register Controllers
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            //Register DbConnectionFactory
            builder.RegisterType<DatabaseConnectionFactory>()
                .As<IDbConnectionFactory>()
                .WithParameter("connectionString", ConfigurationManager.ConnectionStrings["NovelDemoDb"].ConnectionString);


            //Register repositories
            builder.RegisterGeneric(typeof(DapperGenericRepository<>)).As(typeof(IGenericRepository<>));
            builder.RegisterType<AuthorRepository>().As<IAuthorRepository>();
            builder.RegisterType<BookRepository>().As<IBookRepository>();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();


            //Register service
            builder.RegisterType<Services>().As<IServices>();
            builder.RegisterType<AuthorService>().As<IAuthorService>();
            builder.RegisterType<BookService>().As<IBookService>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();


            //Set dependency resolver to be Autofac.
            var container = builder.Build();
            AutofacDependencyResolver resolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(resolver);
        }
    }
}