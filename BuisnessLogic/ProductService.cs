using InMemoryCachingAPI.Models;

namespace InMemoryCachingAPI.BuisnessLogic
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _repository;
        private readonly MemoryCacheService _cache;

        public ProductService(ProductRepository repository, MemoryCacheService cache)
        {
            _repository = repository;
            _cache = cache;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            string cacheKey = "allproducts";
            return _cache.GetOrCreateList(cacheKey,()=>_repository.GetAllProducts());
        }

        public Product GetProduct(int id)
        {
            string cacheKey = $"product_{id}";
            return _cache.GetOrCreate(cacheKey, () => _repository.GetById(id));
        }
    }
}
