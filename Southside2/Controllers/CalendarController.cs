using CalvarySouthside.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Southside2.Controllers
{
    [OutputCache(Location = System.Web.UI.OutputCacheLocation.Server, Duration = (int)Seconds.OneWeek, VaryByParam = "none")]
    public class CalendarController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
