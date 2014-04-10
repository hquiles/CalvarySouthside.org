using CalvarySouthside;
using CalvarySouthside.Podcast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Southside2.Areas.Media.Controllers
{
    public class SermonsController : Controller
    {
        //
        // GET: /Media/Sermons/

        public ActionResult Index()
        {
            var parser = new XmlParser();
            var items = parser.Parse(ConfigurationHelper.SermonPodcastUrl);

            return View(items);
        }

    }
}
