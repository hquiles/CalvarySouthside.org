using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalvarySouthside.Forms;

public partial class prayer_requests_prayer : System.Web.UI.Page
{
    Guid Key;

    protected void Page_Load(object sender, EventArgs e)
    {
        string key = Request.QueryString["key"];
        if (string.IsNullOrEmpty(key) || !Guid.TryParse(key, out Key))
            Redirect();

        LoadPrayer();
    }

    private void LoadPrayer()
    {
        Message message = new Message(Key);

        // only display prayer requests
        if (message.MessageType != MessageType.PrayerRequest)
            Redirect();

        if (message.Anonymous)
            lblName.Text = "Anonymous";
        else
            lblName.Text = string.Format("{0} {1}", message.FirstName, message.LastName);

        lblMessage.Text = message.MessageBody;
    }

    private void Redirect()
    {
        Response.Redirect("~/prayer-requests");
    }
}