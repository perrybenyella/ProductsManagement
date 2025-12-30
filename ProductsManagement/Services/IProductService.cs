using ProductsManagement.Models;

namespace ProductsManagement.Services
{
    public interface IProductService
    {
        IEnumerable<Product>  GetAllProducts();
        Product? GetProductById(int id);
        void AddedProduct(Product product);
        void UpdateProduct(int id, Product product);
        void DeletableProduct(int id);
    }
}
