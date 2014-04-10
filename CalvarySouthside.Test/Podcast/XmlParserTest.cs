using CalvarySouthside.Podcast;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CalvarySouthside.Test.Podcast
{
    [TestClass]
    public class XmlParserTest
    {


        [TestMethod]
        public void Parse_ReturnsExpected()
        {
            var xmlParser = new XmlParser();
            List<PodcastItem> result = xmlParser.Parse("https://dl.dropboxusercontent.com/u/128970065/Podcast/CalvarySouthside.org-Podcast.xml");

            var oldestItem = result.OrderBy(x => x.PublishedDate).First();

            Assert.AreEqual("Genesis 42", oldestItem.Title);
        }

        [TestMethod]
        public void Parse_BadUrl()
        {
            var xmlParser = new XmlParser();
            List<PodcastItem> result = xmlParser.Parse("https://dl.dropboxusercontent.com/u/128970065/Podcast/BADURL");

            Assert.AreEqual(0, result.Count);
        }

    }
}
