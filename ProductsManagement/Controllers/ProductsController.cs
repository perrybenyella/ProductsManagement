using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts() // Get method that gets the list of products
        {
            var products = new[]
            {
                new { Id = 1, Name = "Laptop", Price = 999.99 },
                new { Id = 2, Name = "Smartphone", Price = 499.99 },
                new { Id = 3, Name = "Tablet", Price = 299.99 }
            };
            return Ok(products); // Returns a list of products with HTTP 200 status
        }
    }
}
