using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class assets_Main : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DisplayGoogleAnalytics();

        if (!IsPostBack)
        {
            Page.Title = string.Format("Calvary Chapel Southside - {0}", Page.Title);
        }
    }

    private void DisplayGoogleAnalytics()
    {
        // don't load google analytics in development environments
        string hostName = Request.ServerVariables["SERVER_NAME"].ToLower();
        pnlGoogleAnalytics.Visible = hostName.Contains("calvarysouthside");
    }
}
