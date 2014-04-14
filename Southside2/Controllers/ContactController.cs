using CalvarySouthside.Enums;
using CalvarySouthside.Forms;
using System.Web.Mvc;

namespace Southside2.Controllers
{
    public class ContactController : Controller
    {
        [OutputCache(Location = System.Web.UI.OutputCacheLocation.Server, Duration = (int)Seconds.OneMonth, VaryByParam = "none")]
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Location = System.Web.UI.OutputCacheLocation.Server, Duration = (int)Seconds.OneMonth, VaryByParam = "none")]
        public ActionResult ThankYou()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Southside2.Models.ContactModel contactModel)
        {
            Message message = new Message();

            message.MessageType = MessageType.General;
            message.Anonymous = false;
            message.LastName = contactModel.LastName;
            message.FirstName = contactModel.FirstName;
            message.EmailAddress = contactModel.EmailAddress;
            message.MessageBody = contactModel.MessageBody;

            message.Submit();

            Response.Redirect("/Contact/ThankYou");

            return View();
        }

    }
}
