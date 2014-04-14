using System.Collections;
using System.Web.Mvc;

namespace Southside2.Controllers
{
    public class CacheController : Controller
    {
        public ActionResult Refresh()
        {
            IDictionaryEnumerator enumerator = System.Web.HttpContext.Current.Cache.GetEnumerator();

            while (enumerator.MoveNext())
            {
                System.Web.HttpContext.Current.Cache.Remove(enumerator.Key.ToString());
            }

            return Redirect("/");
        }
    }
}
