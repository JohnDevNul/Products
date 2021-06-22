using Activity2.Models;
using Activity2.Services;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            ProductsDAO products = new ProductsDAO();


            return View(products.GetAllProducts());
        }

        public IActionResult SearchResult(string searchTerm)
        {
            ProductsDAO products = new ProductsDAO();

            List<ProductModel> productList = products.SearchProducts(searchTerm);

            return View("index", productList);
        }

        public IActionResult ShowDetails(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View(foundProduct);
        }

        public IActionResult Edit(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View("ShowEdit", foundProduct);
        }

        public IActionResult ProcessEdit(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();
            products.Update(product);
            return View("Index", products.GetAllProducts());
        }

        public IActionResult Create()
        {
            return View("ProductForm");
        }

        public IActionResult ProcessCreate(ProductModel productModel)
        {
            
            return View("Details", productModel.Id);
        }

        public IActionResult Delete(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel product = products.GetProductById(id);
            products.Delete(product);
            return View("Index", products.GetAllProducts());
        }

        public IActionResult SearchForm()
        {
            return View();
        }

        public IActionResult Message()
        {
            return View("message");
        }

        public IActionResult Welcome(string name, int secNum=3 )
        {
            ViewBag.Name = name;
            ViewBag.Secnum = secNum;
            return View(); 
        }
    }
}
