using Microsoft.Extensions.Caching.Memory;

namespace InMemoryCachingAPI.Models
{
    public class MemoryCacheService
    {
        private readonly IMemoryCache _cache;
        private readonly MemoryCacheEntryOptions _options;

        public MemoryCacheService(IMemoryCache cache)
        {
            _cache = cache;
            _options = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5), // Cache valid for 5 min
                SlidingExpiration = TimeSpan.FromMinutes(2)               // Extend if accessed
            };
        }

        public T GetOrCreate<T>(string key, Func<T> fetchFunction)
        {
            if (!_cache.TryGetValue(key, out T value))
            {
                value = fetchFunction();
                _cache.Set(key, value, _options);
            }
            return value;
        }

        

        // Get all list of items
        public IEnumerable<T> GetOrCreateList<T>(string key, Func<IEnumerable<T>> fetchFunction)
        {
            if (!_cache.TryGetValue(key, out IEnumerable<T> value))
            {
                value = fetchFunction();
                _cache.Set(key, value, _options);
            }
            return value;
        }

        public void Remove(string key) => _cache.Remove(key);
    }
}
