using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;

namespace EasyAbp.Abp.MultiLevelCache
{
    public class HybridCache<TCacheItem> : IHybridCache<TCacheItem> where TCacheItem : class
    {
        public TCacheItem Get(string key, bool? hideErrors = null, bool considerUow = false)
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<string, TCacheItem>[] GetMany(IEnumerable<string> keys, bool? hideErrors = null, bool considerUow = false)
        {
            throw new NotImplementedException();
        }

        public Task<KeyValuePair<string, TCacheItem>[]> GetManyAsync(IEnumerable<string> keys, bool? hideErrors = null, bool considerUow = false,
            CancellationToken token = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<TCacheItem> GetAsync(string key, bool? hideErrors = null, bool considerUow = false, CancellationToken token = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public TCacheItem GetOrAdd(string key, Func<TCacheItem> factory, Func<DistributedCacheEntryOptions> optionsFactory = null, bool? hideErrors = null,
            bool considerUow = false)
        {
            throw new NotImplementedException();
        }

        public Task<TCacheItem> GetOrAddAsync(string key, Func<Task<TCacheItem>> factory, Func<DistributedCacheEntryOptions> optionsFactory = null, bool? hideErrors = null,
            bool considerUow = false, CancellationToken token = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<string, TCacheItem>[] GetOrAddMany(IEnumerable<string> keys, Func<IEnumerable<string>, List<KeyValuePair<string, TCacheItem>>> factory,
            Func<DistributedCacheEntryOptions> optionsFactory = null, bool? hideErrors = null, bool considerUow = false)
        {
            throw new NotImplementedException();
        }

        public Task<KeyValuePair<string, TCacheItem>[]> GetOrAddManyAsync(IEnumerable<string> keys, Func<IEnumerable<string>, Task<List<KeyValuePair<string, TCacheItem>>>> factory,
            Func<DistributedCacheEntryOptions> optionsFactory = null, bool? hideErrors = null, bool considerUow = false,
            CancellationToken token = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public void Set(string key, TCacheItem value, DistributedCacheEntryOptions options = null, bool? hideErrors = null, bool considerUow = false)
        {
            throw new NotImplementedException();
        }

        public Task SetAsync(string key, TCacheItem value, DistributedCacheEntryOptions options = null, bool? hideErrors = null, bool considerUow = false,
            CancellationToken token = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public void SetMany(IEnumerable<KeyValuePair<string, TCacheItem>> items, DistributedCacheEntryOptions options = null, bool? hideErrors = null, bool considerUow = false)
        {
            throw new NotImplementedException();
        }

        public Task SetManyAsync(IEnumerable<KeyValuePair<string, TCacheItem>> items, DistributedCacheEntryOptions options = null, bool? hideErrors = null,
            bool considerUow = false,
            CancellationToken token = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public void Refresh(string key, bool? hideErrors = null)
        {
            throw new NotImplementedException();
        }

        public Task RefreshAsync(string key, bool? hideErrors = null, CancellationToken token = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public void RefreshMany(IEnumerable<string> keys, bool? hideErrors = null)
        {
            throw new NotImplementedException();
        }

        public Task RefreshManyAsync(IEnumerable<string> keys, bool? hideErrors = null, CancellationToken token = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public void Remove(string key, bool? hideErrors = null, bool considerUow = false)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(string key, bool? hideErrors = null, bool considerUow = false, CancellationToken token = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public void RemoveMany(IEnumerable<string> keys, bool? hideErrors = null, bool considerUow = false)
        {
            throw new NotImplementedException();
        }

        public Task RemoveManyAsync(IEnumerable<string> keys, bool? hideErrors = null, bool considerUow = false, CancellationToken token = new CancellationToken())
        {
            throw new NotImplementedException();
        }
    }
}