using Store.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Services.Contracts
{
    public  interface IProductService
    {
        List<ProductDto> GetProducts();

        void AddProduct(ProductCreateDto product);

        void RemoveProduct(int id);

        void UpdateProduct(int id ,ProductDto product);

    }
}
