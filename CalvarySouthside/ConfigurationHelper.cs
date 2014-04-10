using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CalvarySouthside
{
    public static class ConfigurationHelper
    {
        public static string ChurchAddress
        {
            get { return ConfigurationManager.AppSettings["ChurchAddress"]; }
        }

        public static string ChurchPhoneNumber
        {
            get { return ConfigurationManager.AppSettings["ChurchPhoneNumber"]; }
        }

        public static string ChurchEmailAddress
        {
            get { return ConfigurationManager.AppSettings["ChurchEmailAddress"]; }
        }

        public static string GoogleMapsUrl
        {
            get { return ConfigurationManager.AppSettings["GoogleMapsUrl"]; }
        }

        public static string SermonPodcastUrl
        {
            get { return ConfigurationManager.AppSettings["SermonPodcastUrl"]; }
        }

    }
}
