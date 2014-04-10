using System;
using System.Collections.Generic;
using System.Xml;

namespace CalvarySouthside.Podcast
{
    public class XmlParser
    {
        public List<PodcastItem> Parse(string podcastUrl)
        {
            var list = new List<PodcastItem>();

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(podcastUrl);

                foreach (XmlNode item in xmlDoc.GetElementsByTagName("item"))
                {
                    var podcast = new PodcastItem();
                    podcast.Title = item["title"].InnerText;
                    podcast.Url = item["enclosure"].Attributes["url"].InnerText;
                    podcast.SetPublishedDate(item["pubDate"].InnerText);

                    list.Add(podcast);
                }

            }
            catch(Exception ex)
            {
                // TODO: log exception
            }

            return list;
        }
    }
}
