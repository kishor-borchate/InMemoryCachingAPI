namespace InMemoryCachingAPI.Models
{
    public class ProductRepository
    {
        // Normally fetch from DB
        public Product GetById(int id)
        {
            return new Product
            {
                Id = id,
                Name = $"Product {id}",
                Price = 100 + id
            };
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
                new Product { Id = 1, Name = "Ac", Price = 100 },
            };
            return products;

        }
    }
}
