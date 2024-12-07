
using Microsoft.EntityFrameworkCore;
using EcommerceMVC.Models.Services;
using EcommerceMVC.Models;
using Microsoft.AspNetCore.Http;

namespace EcommerceMVC.Models.Services
{
    
    

        public class ProductService: IProductService
        {
            private readonly ApplicationDbContext context;

            public ProductService(ApplicationDbContext context)
            {
                this.context = context;
            }

            public void CreateProduct(ProductDto productDto)
            {
                var product = new Product
                {
                    Name = productDto.Name,
                    Brand = productDto.Brand,
                    Category = productDto.Category,
                    Price = productDto.Price,
                    Description = productDto.Description,
                    ImageFile = productDto.ImageFile


                };

                context.Products.Add(product);
                context.SaveChanges();
            }

            
        }

    }





    