using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalvarySouthside.Forms;

using System.Data;
using System.Data.SqlClient;

public partial class prayer_requests_default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void SubmitForm(object sender, EventArgs e)
    {
        // submit message
        Message message = new Message();

        message.MessageType = ddlPrayerOrPraise.SelectedValue == "praise" ? MessageType.PraiseReport : MessageType.PrayerRequest;
        message.Anonymous = tsAnonymous.Checked;
        message.LastName = txtLastName.Text;
        message.FirstName = txtFirstName.Text;
        message.EmailAddress = txtEmailAddress.Text;
        message.MessageBody = txtMessage.Text;

        message.Submit();

        // show confirmation
        tblSubmissionForm.Visible = false;
        pnlConfirmationMessage.Visible = true;

        // send email confirmation, including link
    }

}