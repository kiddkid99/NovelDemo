using NovelDemo.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovelDemo.Models.Entity;
using NovelDemo.Models.Repositories.Interface;

namespace NovelDemo.Service.Implement
{
    public class AuthorService : IAuthorService
    {
        private IAuthorRepository repository;

        public AuthorService(IAuthorRepository repository)
        {
            this.repository = repository;
        }

        public IResult Delete(Author entity)
        {
            IResult result = new Result();

            try
            {
                if(!IsExist(entity.Id))
                {
                    result.Message = "找不到資料";
                }
                else
                {
                    repository.Delete(entity);
                    result.Success = true;
                }
            }
            catch(Exception ex)
            {
                result.Exception = ex;
            }

            return result;
        }

        public IEnumerable<Author> GetAll()
        {
            return repository.GetAll();
        }

        public IResult Insert(Author entity)
        {
            IResult result = new Result();

            try
            {
                if (IsExist(entity.Id))
                {
                    result.Message = "資料已存在";
                }
                else
                {
                    entity.CreateTime = DateTime.Now;
                    entity.Status = 1;
                    repository.Insert(entity);
                    result.Success = true;
                }
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }

            return result;
        }

        public IResult Update(Author entity)
        {
            IResult result = new Result();

            try
            {
                if (!IsExist(entity.Id))
                {
                    result.Message = "找不到資料";
                }
                else
                {
                    entity.UpdateTime = DateTime.Now;
                    repository.Update(entity);
                    result.Success = true;
                }
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }

            return result;
        }

        public bool IsExist(int id)
        {
            var model = repository.Get(id);
            return model != null;
        }

        public Author GetById(int id)
        {
            return repository.Get(id);
        }
    }
}
