using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsManagement.Models;

namespace ProductsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> Products = new()
        {
                new() { Id = 1, Name = "Laptop", Price = 1199.99m, Description = "High-performance laptop" },
                new() { Id = 2, Name = "Smartphone", Price = 799.99m, Description = "Latest model smartphone" },
                new() { Id = 3, Name = "Tablet", Price = 299.99m, Description = "Latest model tablet" }
            };

        // GET: api/products
        [HttpGet]
        public IActionResult GetProducts() // Get method that gets the list of products
        {
            return Ok(Products); // Returns a list of products with HTTP 200 status
        }

        // GET: api/products/{id}
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProductById(int id)
        {

            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(); // Returns HTTP 404 if product not found
            }
            return Ok(product); // Returns the product with HTTP 200 status
        }

        

    }
}
