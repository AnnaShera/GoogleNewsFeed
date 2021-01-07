using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Caching;

namespace GoogleNews
{
    public class CacheControl
    {
        //Remove all cache elements
        public static void ClearCache()
        {
            foreach (var element in MemoryCache.Default)
            {
                MemoryCache.Default.Remove(element.Key);
            }
        }

        //Add each NewsFeed instance to the cache with id as cache key
        public static void PopulateCache(List<NewsFeed> NewsList)
        {
            foreach (NewsFeed feed in NewsList)
            {
                MemoryCache.Default.Add(feed.id.ToString(), feed, DateTimeOffset.MaxValue);
            }
        }
    }
}