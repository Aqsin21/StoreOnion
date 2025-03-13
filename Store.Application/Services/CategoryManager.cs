using Academy.Application.Repositories;
using Store.Application.DTOs;
using Store.Application.Repositories;
using Store.Application.Services.Contracts;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Services
{
    public class CategoryManager :ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryManager(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public void AddCategory(CategoryCreateDto createDto)
        {
            var category = new Category
            {
                Name = createDto.Name,
                
            };
            _repository.Add(category);
        }

        public CategoryDto GetCategory(Func<Category, bool> predicate)
        {
            var category = _repository.Get(predicate);

            var categoryDto = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
               
            };

            return categoryDto;
        }

        public List<CategoryDto> GetCategories(Expression<Func<Category, bool>>? predicate = null)
        {
            var categoryDtos = new List<CategoryDto>();

            foreach (var item in _repository.GetAll(predicate))
            {
                categoryDtos.Add(new CategoryDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    
                });
            }

            return categoryDtos;
        }

        public void RemoveCategory(int id)
        {
            _repository.Remove(id);
        }

        public void UpdateCategory(int id, Category category)
        {
            _repository.Update(id, category);
        }

    }
}

