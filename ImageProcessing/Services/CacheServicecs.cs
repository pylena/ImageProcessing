namespace ImageProcessing.Services
{
    public class CacheServicecs : ICacheService
    {
        private readonly Dictionary<string, byte[]> _cache = new();
        public byte[] Get(string key)
        {
            if (_cache.TryGetValue(key, out var data))
            {
                return data;
            }
            return null;
        }
        public void Set(string key, byte[] data)
        {
            _cache[key] = data;
        }
    }
}
