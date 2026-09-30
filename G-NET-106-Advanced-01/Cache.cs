using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_Advanced_01
{
    internal class Cache<TKey, TValue>
    {
        private readonly List<CacheItem<TKey, TValue>> items = new List<CacheItem<TKey, TValue>>();


        public void Add(TKey key, TValue value, int secondsToLive)
        {
            Remove(key);
            items.Add(new CacheItem<TKey, TValue>(key, value, secondsToLive));
        }

        public bool Contains(TKey key)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (Equals(items[i].Key, key))
                {
                    if (!items[i].IsExpired)
                        return true;

                    items.RemoveAt(i);
                    return false;
                }
            }
            return false;
        }

        public TValue Get(TKey key)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (Equals(items[i].Key, key))
                {
                    if (!items[i].IsExpired)
                        return items[i].Value;

                    items.RemoveAt(i);
                    break;
                }

                
    
            }
            throw new KeyNotFoundException($"Key '{key}' was not found or expired.");
        }

        public bool Remove(TKey key)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (Equals(items[i].Key, key))
                {
                    items.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}

