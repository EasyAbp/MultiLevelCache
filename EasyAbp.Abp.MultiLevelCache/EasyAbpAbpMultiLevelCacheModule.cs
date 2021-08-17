using Volo.Abp.Caching;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.MultiLevelCache
{
    [DependsOn(typeof(AbpCachingModule))]
    public class EasyAbpAbpMultiLevelCacheModule : AbpModule
    {
    }
}