using CalvarySouthside.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Southside2.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
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

            return View();
        }

    }
}
