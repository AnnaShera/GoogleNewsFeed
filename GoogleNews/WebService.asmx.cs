using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Runtime.Caching;
using System.Web.Script.Services;
namespace GoogleNews
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]

    public class WebService : System.Web.Services.WebService
    {
        //Retrieve a single feed data from cache according to the provided rssFeedId
        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public NewsFeed ExtrectRssData(string rssFeedId)
        {
            string JsonString = string.Empty;
            ObjectCache cache = MemoryCache.Default;
            NewsFeed feed = (NewsFeed)cache.Get(rssFeedId);
            return feed;
        }
    }
}
