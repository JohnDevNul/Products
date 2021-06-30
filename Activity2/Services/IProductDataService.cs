using Activity2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Services
{
    interface IProductDataService
    {
        List<ProductModelDAO> GetAllProducts();
        List<ProductModelDAO> SearchProducts(string searchTerm);
        ProductModelDAO GetProductById(int id);
        int Insert(ProductModelDAO product);
        int Delete(ProductModelDAO product);
        int Update(ProductModelDAO product);
    }
}
