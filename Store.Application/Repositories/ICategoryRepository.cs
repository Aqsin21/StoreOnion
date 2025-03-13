using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Repositories
{
    public  interface ICategoryRepository
    {
        List<Category> GetProducts();

        void AddCategory(Category category);

        void UpdateCategory(int Id , Category category);

        void RemoveCategory (int Id);

    }
}
