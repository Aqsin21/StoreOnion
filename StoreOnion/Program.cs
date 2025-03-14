using Store.Application.Services;
using Store.Application.Repositories;
using Store.Domain.Entities;
using Store.Infrastructure.EfCore;
using Store.Infrastructure.Repositories;
using Store.Application.DTOs;
using System;

namespace StoreOnion
{
    public class Program
    {
        static void Main(string[] args)
        {
            var appDbContext = new AppDbContext();
            var categoryRepo = new CategoryRepository(appDbContext);
            var productRepo = new ProductRepository(appDbContext);

            
            var categoryManager = new CategoryManager(categoryRepo);
            var productManager = new ProductManager(productRepo);

            
            categoryManager.AddCategory(new CategoryCreateDto
            {
                Name = "Phones"
            });

            
            productManager.AddProduct(new ProductCreateDto
            {
                Name = "iPhone 15 Pro",
                CategoryId = 1 
            });

            
            foreach (var product in productManager.GetProducts())
            {
                Console.WriteLine($"Ürün: {product.Name} ");

                
                Console.WriteLine($"Kategori: {product.CategoryName}"); 
            }

        }
    }
}
