using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Context;
using WebApp.Models;

namespace WebApp.Apis
{
    [Route("api/[controller]")]
    public class ProductApiController : Controller
    {
        private readonly WebDbContext _context;
        public ProductApiController(WebDbContext context)
        {
            _context = context;
        }

        [HttpDelete("delete-product")]
        public IActionResult DeleteProduct(int id)
        {
            return Ok(true);
        }

        [HttpPut("update-product")]
        public IActionResult UpdateProduct(Product product)
        {
            return Ok(product);
        }

        [HttpGet("get-details/{id}")]
        public IActionResult GetDetails(int id)
        {
            var findProduct = _context.Products.FirstOrDefault(p => p.Id == id);
            return Ok(findProduct);
        }
        [HttpPost("create-product")]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }

        [HttpGet("get-products")]
        public IActionResult GetProducts()
        {
            var productList = _context.Products.ToList();
            return Ok(productList);
        }
    }
}
