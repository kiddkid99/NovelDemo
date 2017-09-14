using NovelDemo.Models.Entity;
using NovelDemo.Models.Repositories.Interface;
using NovelDemo.Service.Interface;
using System;
using System.Collections.Generic;

namespace NovelDemo.Service.Implement
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository repository;


        public CategoryService(ICategoryRepository repository)
        {
            this.repository = repository;
        }

        public IResult Delete(Category entity)
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
                    repository.Delete(entity);
                    result.Success = true;
                }
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }

            return result;
        }

        public IEnumerable<Category> GetAll()
        {
            return repository.GetAll();
        }

        public Category GetById(int id)
        {
            return repository.Get(id);
        }

        public IResult Insert(Category entity)
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

        public bool IsExist(int id)
        {
            return repository.Get(id) != null;
        }

        public IResult Update(Category entity)
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
    }
}
