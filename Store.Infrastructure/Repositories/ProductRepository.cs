using Store.Application.Repositories;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(int Id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
