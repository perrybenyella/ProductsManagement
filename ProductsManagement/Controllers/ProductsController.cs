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
        private readonly IProductService service;

        public ProductsController(IProductService service)
        {
            this.service = service; // now, inject the productService dependency into the controller
        }

        // GET: api/products
        [HttpGet]
        public IActionResult GetProducts() // Get method that gets the list of products
        {
            return Ok(service.GetAllProducts()); // Returns a list of products with HTTP 200 status
        }

        // GET: api/products/{id}
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = service.GetProductById(id);
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
            try
            {
                service.UpdateProduct(id, product); // Update the product
                return NoContent(); // Returns HTTP 204 status
            }
            catch (Exception) // if product with given id does not exist
            {
                return NotFound(); // Returns HTTP 404 if product not found
            }
        }

        // DELETE: api/products/{id}
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try 
            {
                service.DeletableProduct(id); // Delete the product
                return NoContent(); // Returns HTTP 204 status
            }
            catch (Exception) // if product with given id does not exist
            {
                return NotFound(); // Returns HTTP 404 if product not found
            }
        }

    }
}
