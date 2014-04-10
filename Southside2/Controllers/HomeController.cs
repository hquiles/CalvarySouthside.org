using CalvarySouthside;
using CalvarySouthside.Podcast;
using System.Web.Mvc;

namespace Southside2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var parser = new XmlParser();
            var items = parser.Parse(ConfigurationHelper.SermonPodcastUrl);

            return View(items);
        }

    }
}
