using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Repositories
{
    public  interface IProductRepository
    {
        List<Product> GetProducts();


        void AddProduct(Product product);


        void UpdateProduct(int Id, Product product);


        void RemoveProduct(int id);

    }
}
