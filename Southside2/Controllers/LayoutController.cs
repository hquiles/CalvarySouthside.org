using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Southside2.Controllers
{
    /// <summary>
    /// This controller exists only to demonstrate and document 
    /// the available options in the current html/css/bootstrap theme
    /// </summary>
    public class LayoutController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        #region Columns

        public ActionResult ThreeColumn()
        {
            return View();
        }

        public ActionResult FourColumn()
        {
            return View();
        }

        #endregion

        #region Sample Pages

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult BlogArticle()
        {
            return View();
        }

        public ActionResult FullWidth()
        {
            return View();
        }

        public ActionResult Icons()
        {
            return View();
        }

        public ActionResult IndividualWork()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult Team()
        {
            return View();
        }

        #endregion

    }
}
