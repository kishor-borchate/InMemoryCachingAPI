using InMemoryCachingAPI.Models;

namespace InMemoryCachingAPI.BuisnessLogic
{
    public interface IProductService
    {
        Product GetProduct(int id);
        IEnumerable<Product> GetAllProducts();
    }
}
