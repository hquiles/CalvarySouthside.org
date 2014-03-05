using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Southside2.Models
{
    public class ContactModel
    {
        public string MessageType { get; set; }
        public bool Anonymous { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public string MessageBody { get; set; }
    }
}
