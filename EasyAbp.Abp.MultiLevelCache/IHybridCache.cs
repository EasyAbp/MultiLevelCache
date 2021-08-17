using Volo.Abp.Caching;

namespace EasyAbp.Abp.MultiLevelCache
{
    public interface IHybridCache<TCacheItem> : IDistributedCache<TCacheItem, string> where TCacheItem : class
    {
    }
}