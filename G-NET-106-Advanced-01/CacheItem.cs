using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_Advanced_01
{
    internal class CacheItem<TKey, TValue>
    {
        public TKey Key { get; }
        public TValue Value { get; }
        public DateTime Expiration { get; }

        public CacheItem(TKey key, TValue value, int secondsToLive)
        {
            Key = key;
            Value = value;
            Expiration = DateTime.UtcNow.AddSeconds(secondsToLive);
        }

        public bool IsExpired => DateTime.UtcNow >= Expiration;
    }
}
