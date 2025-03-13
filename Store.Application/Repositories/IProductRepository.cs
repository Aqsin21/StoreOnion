using Academy.Application.Repositories;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Repositories
{
    public  interface IProductRepository :IRepository<Product>
    {
        

    }
}
