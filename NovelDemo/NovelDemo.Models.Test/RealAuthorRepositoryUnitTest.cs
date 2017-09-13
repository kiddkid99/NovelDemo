using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using NovelDemo.Models.Repositories.Implement;
using NovelDemo.Models.Repositories.Interface;
using NovelDemo.Models.Entity;

namespace NovelDemo.Models.Test
{
    [TestClass]
    public class RealAuthorRepositoryUnitTest
    {
        private IAuthorRepository repository;

        [TestMethod]
        public void Test_Inser_Real_Data()
        {
            //Arrange
            string connectionString = ConfigurationManager.ConnectionStrings["NovelDemoDb"].ToString();
            repository = new AuthorRepository(new DatabaseConnectionFactory(connectionString));

            Author data = new Author() { FirstName = "Wang", LastName = "Kidd", Status = 1, CreateTime = DateTime.Now };


            //Action
            repository.Insert(data);

            //Asset
            
        }


        [TestMethod]
        public void Test_Get_Real_Data()
        {
            //Arrange
            string connectionString = ConfigurationManager.ConnectionStrings["NovelDemoDb"].ToString();
            repository = new AuthorRepository(new DatabaseConnectionFactory(connectionString));


            //Action
            var data = repository.GetAll();

            //Asset

        }


    }
}
