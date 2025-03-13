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
    public  interface IProductService
    {
        List<ProductDto> GetProducts(Expression<Func<Product, bool>>? predicate = null);

        void AddProduct(ProductCreateDto product);

        void RemoveProduct(int id);

        void UpdateProduct(int id ,Product product);

    }
}
