using ProductsManagement.Data;
using ProductsManagement.Models;

namespace ProductsManagement.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext context;

        public ProductService(AppDbContext appDbContext) 
        { 
            context = appDbContext; // inject the appDbContext dependency
        }

        public void AddedProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeletableProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product? GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
