using Store.Application.DTOs;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Services.Contracts
{
    public interface ICategoryService
    {
        List<CategoryDto> GetCategories(Expression<Func<Category, bool>>? predicate = null);

        void AddCategory(CategoryCreateDto category);

        void RemoveCategory(int id);

        void UpdateCategory(int id, Category category);
    }
}
