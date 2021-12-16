using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Apis
{
    [Route("api/[controller]")]
    public class ProductApiController : Controller
    {
        [HttpGet("get-details/{id}")]
        public IActionResult GetDetails(int id)
        {
            var productList = new List<Product>();

            productList.Add(new Product
            {
                Id = 1,
                Name = "Tin Tomato"
            });
            productList.Add(new Product
            {
                Id = 2,
                Name = "Tissue Paper"
            });
            productList.Add(new Product
            {
                Id = 3,
                Name = "Cutleries"
            });

            var findProduct = productList.FirstOrDefault(p => p.Id == id);
            return Ok(findProduct);
        }
        [HttpPost("create-product")]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            product.Id = 1;
            product.Price = 800;
            return Ok(product);
        }

        [HttpGet("get-products")]
        public IActionResult GetProducts()
        {
            var productList = new List<Product>();

            productList.Add(new Product
            {
                Id = 1,
                Name = "Tin Tomato"
            });
            productList.Add(new Product
            {
                Id = 2,
                Name = "Tissue Paper"
            });
            productList.Add(new Product
            {
                Id = 3,
                Name = "Cutleries"
            });

            return Ok(productList);
        }
    }
}
