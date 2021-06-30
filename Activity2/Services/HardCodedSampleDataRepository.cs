using Activity2.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Services
{
    public class HardCodedSampleDataRepository : IProductDataService
    {
        static List<ProductModelDAO> productsList = new List<ProductModelDAO>();
        public int Delete(ProductModelDAO product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModelDAO> GetAllProducts()
        {
            if (productsList.Count == 0)
            {
                productsList.Add(new ProductModelDAO { Id = 0, Name = "shit", Price = 4.4m, Description = "Just shit" });
                productsList.Add(new ProductModelDAO { Id = 1, Name = "glass", Price = 3.6m, Description = "Just glass" });
                productsList.Add(new ProductModelDAO { Id = 2, Name = "iron", Price = 5.4m, Description = "Just iron" });
                productsList.Add(new ProductModelDAO { Id = 3, Name = "shirt", Price = 7.4m, Description = "Just shirt" });
                productsList.Add(new ProductModelDAO { Id = 4, Name = "pussy", Price = 6.4m, Description = "Just pussy" });

                for (int i = 0; i < 100; i++)
                {
                    productsList.Add(new Faker<ProductModelDAO>()
                        .RuleFor(p => p.Id, i + 5)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                        .RuleFor(p => p.Description, f => f.Rant.Review())
                        );
                }
            }
            return productsList;
        }

        public ProductModelDAO GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModelDAO product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModelDAO> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModelDAO product)
        {
            throw new NotImplementedException();
        }
    }
}
