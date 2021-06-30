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
        ProductsRepository repository;

        public ProductsController()
        {
            repository = new ProductsRepository();
        }
        public IActionResult Index()
        {
           return View(repository.GetAllProducts());
        }

        public IActionResult SearchResult(string searchTerm)
        {
            List<ProductModelDAO> productList = repository.SearchProducts(searchTerm);

            return View("index", productList);
        }

        public IActionResult ShowDetails(int id)
        {
            ProductModelDAO foundProduct = repository.GetProductById(id);
            return View(foundProduct);
        }

        public IActionResult ShowOneProductJSON(int Id)
        {

            return Json(repository.GetProductById(Id));
        }

        public IActionResult Edit(int id)
        {
            ProductModelDAO foundProduct = repository.GetProductById(id);
            return View("ShowEdit", foundProduct);
        }

        public IActionResult ProcessEdit(ProductModelDAO product)
        {
            repository.Update(product);
            return View("Index", repository.GetAllProducts());
        }

        public IActionResult ProcessEditReturnPartial(ProductModelDAO product)
        {
            repository.Update(product);
            return PartialView("_productCard", product);    
        }

        public IActionResult Create()
        {
            return View("ProductForm");
        }

        public IActionResult ProcessCreate(ProductModelDAO product)
        {
            repository.Insert(product);
            return View("Index", repository.GetAllProducts());
        }

        public IActionResult Delete(int id)
        {
            ProductModelDAO product = repository.GetProductById(id);
            repository.Delete(product);
            return View("Index", repository.GetAllProducts());
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
