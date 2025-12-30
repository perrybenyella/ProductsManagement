using ProductsManagement.DTOs;
using ProductsManagement.Models;

namespace ProductsManagement.Services
{
    public interface IProductService
    {
        IEnumerable<ProductResponse>  GetAllProducts();
        ProductResponse? GetProductById(int id);
        ProductResponse AddProduct(ProductRequest product);
        void UpdateProduct(int id, Product product);
        void DeleteProduct(int id);
    }
}
