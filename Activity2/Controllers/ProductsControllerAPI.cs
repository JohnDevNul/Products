using Activity2.Models;
using Activity2.Services;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace Activity2.Controllers
{
    [ApiController]
    [Route("api/")]
    public class ProductsControllerAPI : Controller
    {
        ProductsRepository repository;

        public ProductsControllerAPI()
        {
            repository = new ProductsRepository();
        }
        [HttpGet]
        [ResponseType(typeof(List<ProductModelDTO>))]
        public IEnumerable<ProductModelDTO> Index()
        {
            List<ProductModelDAO> products = repository.GetAllProducts();

            //List<ProductModelDTO> productDTOs = new List<ProductModelDTO>();

            IEnumerable<ProductModelDTO> productModelDTOs = from p in products select new ProductModelDTO(p);

            //foreach(var p in products)
            //{
            //    productDTOs.Add(new ProductModelDTO(p));
            //}

            return productModelDTOs;
        }

        [HttpGet("searchresult/{searchTerm}")]
        public ActionResult <IEnumerable<ProductModelDTO>> SearchResult(string searchTerm)
        {
            List<ProductModelDAO> productList = repository.SearchProducts(searchTerm);

            List<ProductModelDTO> pDTOList = new List<ProductModelDTO>();

            foreach (var p in productList)
            {
                pDTOList.Add(new ProductModelDTO(p));
            }

            return pDTOList;
        }
        
        [HttpGet("ShowOneProduct/{Id}")]
        public ActionResult <ProductModelDTO> ShowOneProduct(int id)
        {
            ProductModelDAO p = repository.GetProductById(id);

            ProductModelDTO pDTO = new ProductModelDTO(p);

            return pDTO;
        }

        [HttpPost("processCreate")]
        public ActionResult <int> ProcessCreate(ProductModelDTO product)
        {
            var pDAO = new ProductModelDAO2(product);
            
            var newId = pDAO.Insert(product);

            var pDTO = new ProductModelDTO(repository.GetProductById(newId));
            
            return pDTO;
        }

        [HttpPut("processEdit")]
        public ActionResult <ProductModelDTO> ProcessEdit(ProductModelDAO product)
        {
            int newId = repository.Update(product);

            ProductModelDTO pDTO = new ProductModelDTO(repository.GetProductById(newId));

            return pDTO;
        }
        
        [HttpDelete("Delete/{Id}")]
        public ActionResult <int> Delete(int Id)
        {
            ProductModelDAO product = repository.GetProductById(Id);

            var success = repository.Delete(product);

            return success;
        }
    }
}
