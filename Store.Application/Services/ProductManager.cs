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
    public class ProductManager : IProductService
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

            _repository.Add(student);
        }

        public ProductDto GetStudent(Func<Product, bool> predicate)
        {
            var product = _repository.Get(predicate);

            var productDto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                CategoryName = product.Category.Name
            };

            return productDto;
        }

        public List<ProductDto> GetProducts(Expression<Func<Product, bool>>? predicate = null)
        {
            var productDtos = new List<ProductDto>();

            foreach (var item in _repository.GetAll(predicate))
            {
                productDtos.Add(new ProductDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    CategoryName = item.Category.Name
                });
            }

            return productDtos;
        }

        public void RemoveProduct(int id)
        {
            _repository.Remove(id);
        }

        public void UpdateProduct(int id, Product product)
        {
            _repository.Update(id, product);
        }

    }
}
