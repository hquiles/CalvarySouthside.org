using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalvarySouthside.Forms;

public partial class contact_default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitForm(object sender, EventArgs e)
    {
        Message message = new Message();

        message.MessageType = MessageType.General;
        message.Anonymous = false;
        message.LastName = txtLastName.Text;
        message.FirstName = txtFirstName.Text;
        message.EmailAddress = txtEmailAddress.Text;
        message.MessageBody = txtMessage.Text;

        message.Submit();
    }

}