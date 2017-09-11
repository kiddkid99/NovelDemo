using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NovelDemo.Models.Repositories.Interface;
using NovelDemo.Models.Test.Fake;
using NovelDemo.Models.Entity;

namespace NovelDemo.Models.Test
{
    [TestClass]
    public class AuthorRepositoryUnitTest
    {
        private IAuthorRepository repository;


        [TestMethod]
        public void Test_Get_Exist()
        {
            //Arrange
            repository = new FakeAuthorRepository();
            int id = 1;
            int expected = 1;

            //Action
            var model = repository.Get(id);

            //Asset
            Assert.AreEqual(expected, model.Id);
        }


        [TestMethod]
        public void Test_Get_Not_Exist()
        {
            //Arrange
            repository = new FakeAuthorRepository();
            int id = 3;
            Author expected = null;

            //Action
            var model = repository.Get(id);

            //Asset
            Assert.AreEqual(expected, model);
        }


        [TestMethod]
        public void Test_Insert()
        {
            //Arrange
            repository = new FakeAuthorRepository();
            Author data = new Author() { Id = 3 };

            //Action
            repository.Insert(data);

            //Asset
        }
    }
}
