using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Text;

namespace GoogleNews
{
    public partial class RssFeedForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {           
            if (!this.IsPostBack)
            {
                int id = 0;
                 
                string url = "http://news.google.com/news?pz=1&cf=all&ned=en_il&hl=en&output=rss";
                XmlDataSource xmlSource = new XmlDataSource();
                XElement rssXml = XElement.Load(url);

                //Create News Feed list from extracted RSS data
                var nodes = (from node in rssXml.Elements("channel").Elements("item")
                             orderby node.Element("pubDate").Value descending
                             select new NewsFeed
                             {
                                 id = ++id,
                                 title = node.Element("title").Value,
                                 link = node.Element("link").Value,
                                 description = node.Element("description").Value
                                
                             }
                    );
                List <NewsFeed> NewsList = nodes.ToList();

                //Set the NewsList as data source of the repeater
                RssRepeater.DataSource = NewsList;
                RssRepeater.DataBind();  

                //Remove previous cache elements and add new ones              
                CacheControl.ClearCache();
                CacheControl.PopulateCache(NewsList);
            }

        }
    }
}