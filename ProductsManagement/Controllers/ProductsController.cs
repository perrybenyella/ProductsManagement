using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsManagement.Models;

namespace ProductsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts() // Get method that gets the list of products
        {
            var products = new List<Product>
            {
                new() { Id = 1, Name = "Laptop", Price = 1199.99m, Description = "High-performance laptop" },
                new() { Id = 2, Name = "Smartphone", Price = 799.99m, Description = "Latest model smartphone" },
                new() { Id = 3, Name = "Tablet", Price = 299.99m, Description = "Latest model tablet" }
            };
            return Ok(products); // Returns a list of products with HTTP 200 status
        }
    }
}
