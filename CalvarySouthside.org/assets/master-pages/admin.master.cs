using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Infrastructure;

public partial class assets_master_pages_admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Authentication.IsAuthenticated)
        {
            hlnkUsername.Text = Session["Name"].ToString();
            hlnkUsername.NavigateUrl = string.Format("~/admin/user-profile.aspx?id={0}", Session["UserId"]);
        }
        else
        {
            Response.Redirect("~/admin");
        }
    }
}
