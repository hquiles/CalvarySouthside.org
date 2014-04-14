using CalvarySouthside;
using CalvarySouthside.Enums;
using CalvarySouthside.Podcast;
using System.Web.Mvc;

namespace Southside2.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Location = System.Web.UI.OutputCacheLocation.Server, Duration = (int)Seconds.OneWeek, VaryByParam = "none")]
        public ActionResult Index()
        {
            ViewBag.RenderTime = System.DateTime.Now.ToString();

            var parser = new XmlParser();
            var items = parser.Parse(ConfigurationHelper.SermonPodcastUrl);

            return View(items);
        }

    }
}
