using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalvarySouthside;

using System.Data;
using System.Data.SqlClient;

public partial class prayer_requests_default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitForm(object sender, EventArgs e)
    {
        PrayerRequest pr = null;

        if (chklstPrayerOrPraise.SelectedValue == "0")
            pr = new PrayerRequest();
        else
            pr = new PraiseReport();

        pr.Anonymous = chkAnonymous.Checked;
        pr.PersonId = 0; // 0 for now, until user accounts exists
        pr.LastName = HttpUtility.HtmlEncode(txtLastName.Text);
        pr.FirstName = HttpUtility.HtmlEncode(txtFirstName.Text);
        pr.EmailAddress = HttpUtility.HtmlEncode(txtEmailAddress.Text);
        pr.Message = HttpUtility.HtmlEncode(txtMessage.Text);

        pr.Submit();
    }

}