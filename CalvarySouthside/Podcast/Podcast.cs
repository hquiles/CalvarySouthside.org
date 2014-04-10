using System;

namespace CalvarySouthside.Podcast
{
    public class PodcastItem
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime PublishedDate { get; set; }
        public string PublishedDateRfc1123
        {
            get
            {
                return this.PublishedDate.ToUniversalTime().ToString("R");
            }
        }

        public bool SetPublishedDate(string dateTime)
        {
            DateTime dt = DateTime.MinValue;
            if (DateTime.TryParse(dateTime, out dt))
            {
                PublishedDate = dt;
                return true;
            }

            return false;
        }
    }
}
