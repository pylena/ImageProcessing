namespace ImageProcessing.Services
{
    public interface ICacheService
    {
        byte[] Get(string key);
        void Set(string key, byte[] data);
    }
}
