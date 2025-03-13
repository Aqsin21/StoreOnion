using Store.Application.DTOs;
using Store.Application.Repositories;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Services
{
    public class ProductManager : IProductRepository
    {
        private readonly IProductRepository _repository;

        public ProductManager(IProductRepository repository)
        {
            _repository = repository;
        }

  

        public void AddProduct(ProductCreateDto createDto)
        {
            var product = new Product
            {
                Name = createDto.Name,
                CategoryId = createDto.CategoryId

            };

            _repository.AddProduct(product);
        }

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
