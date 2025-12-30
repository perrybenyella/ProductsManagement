using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsManagement.Models;
using ProductsManagement.Services;

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

        private readonly IProductService service;

        public ProductsController(IProductService service)
        {
            this.service = service; // now, inject the productService dependency into the controller
        }

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

        // PUT: api/products/{id}
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            var existingProduct = Products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null) // if product with given id does not exist, return 404
            {
                return NotFound(); // Returns HTTP 404 if product not found
            }
            // otherwise, update the product details
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Description = product.Description;
            return NoContent(); // Returns HTTP 204 status
        }

        // DELETE: api/products/{id}
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null) // if product with given id does not exist, return 404
            {
                return NotFound(); // Returns HTTP 404 if product not found
            }
            // ohterwise, delete the product
            Products.Remove(product); // Remove the product from the list
            return NoContent(); // Returns HTTP 204 status
        }

    }
}
