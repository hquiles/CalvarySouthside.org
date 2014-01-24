using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalvarySouthside.Forms;

namespace Admin
{
    public partial class Inbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadMessages();
        }

        private void LoadMessages()
        {
            List<Message> messages = Message.GetLatest();

            lvMessages.DataSource = messages;
            lvMessages.DataBind();
        }

        protected string RenderName(object dataItem)
        {
            Message message = (Message)dataItem;

            string name = string.Format("{0} {1}", message.FirstName, message.LastName);

            if (string.IsNullOrEmpty(message.EmailAddress))
                return name;
            else
                return string.Format("<a href='mailto:{0}' title='{0}'>{1}</a>", message.EmailAddress, name);
        }
    }
}