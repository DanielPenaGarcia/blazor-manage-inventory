using Inventory.Data;

namespace Inventory.Interfaces
{
    public interface IProductService
    {
        Task<Product> SaveProduct(Product product);
        Task<List<Product>> GetAllProducts();
    }
}
