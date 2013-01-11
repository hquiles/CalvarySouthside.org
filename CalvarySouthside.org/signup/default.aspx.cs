using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalvarySouthside;

public partial class signup_default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitRegistration(object sender, EventArgs e)
    {
        Person p = new Person();
        p.FirstName = txtFirstName.Text;
        p.LastName = txtLastName.Text;
        p.EmailAddress = txtEmailAddress.Text;
        p.EmailList = chkEmailList.Checked;
        p.PhoneNumber = txtPhoneNumber.Text;
        p.Address1 = txtAddress1.Text;
        p.Address2 = txtAddress2.Text;
        p.City = txtCity.Text;
        p.State = txtState.Text;
        p.Zip = txtZip.Text;

        p.Save();
    }
}