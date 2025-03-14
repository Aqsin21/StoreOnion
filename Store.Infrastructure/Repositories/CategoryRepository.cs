using Store.Application.Repositories;
using Store.Domain.Entities;
using Store.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infrastructure.Repositories
{
    public  class CategoryRepository :EfCoreRepository<Category>  ,ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {

        }
    }
}
