using CalvarySouthside.Enums;
using System.Web.Mvc;

namespace Southside2.Areas.Media.Controllers
{
    [OutputCache(Location = System.Web.UI.OutputCacheLocation.Server, Duration = (int)Seconds.OneYear, VaryByParam = "none")]
    public class BrandController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
