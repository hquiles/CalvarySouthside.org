using CalvarySouthside;
using CalvarySouthside.Enums;
using CalvarySouthside.Podcast;
using System.Web.Mvc;

namespace Southside2.Areas.Media.Controllers
{
    [OutputCache(Location = System.Web.UI.OutputCacheLocation.Server, Duration = (int)Seconds.OneWeek, VaryByParam = "none")]
    public class SermonsController : Controller
    {
        public ActionResult Index()
        {
            var parser = new XmlParser();
            var items = parser.Parse(ConfigurationHelper.SermonPodcastUrl);

            return View(items);
        }

    }
}
