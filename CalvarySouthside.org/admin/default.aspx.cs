using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Infrastructure;

namespace Admin
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Authentication.SignOut();
        }

        protected void SignIn(object sender, EventArgs e)
        {
            string emailAddress = txtEmailAddress.Text;
            string password = txtPassword.Text;

            if (Authentication.SignIn(emailAddress, password))
            {
                // Successful login
                Response.Redirect("~/admin/inbox.aspx");
            }
            else
            {
                // Incorrect
                divError.Visible = true;
            }
        }
    }
}