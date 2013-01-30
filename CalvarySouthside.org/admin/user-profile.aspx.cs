using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalvarySouthside;

namespace Admin
{
    public partial class UserProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadUser();
        }

        private void LoadUser()
        {
            if (string.IsNullOrEmpty(Request.QueryString["Id"]))
                return;

            int id = Convert.ToInt32(Request.QueryString["Id"]);
            Person person = new Person(id);

            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;

            txtEmailAddress.Text = person.EmailAddress;
            chkEmailConfirmed.Checked = person.ConfirmedEmail;
            chkMailingList.Checked = person.EmailList;

            txtPhoneNumber.Text = person.PhoneNumber;
            txtAddress1.Text = person.Address1;
            txtAddress2.Text = person.Address2;
            txtCity.Text = person.City;
            txtState.Text = person.State;
            txtZip.Text = person.Zip;

            //chkAdmin.Checked = person.admin;
        }

        protected void SaveUser(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["Id"]))
                return;

            Person person = new Person();
            person.Id = Convert.ToInt32(Request.QueryString["Id"]);
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            person.EmailAddress = txtEmailAddress.Text;
            person.ConfirmedEmail = chkEmailConfirmed.Checked;
            person.EmailList = chkMailingList.Checked;
            person.PhoneNumber = txtPhoneNumber.Text;
            person.Address1 = txtAddress1.Text;
            person.Address2 = txtAddress2.Text;
            person.City = txtCity.Text;
            person.State = txtState.Text;
            person.Zip = txtZip.Text;
            person.Admin = chkAdmin.Checked;

            if (txtPassword.Text == txtPasswordConfirm.Text)
                person.NewPassword = txtPassword.Text;

            person.Save();
        }
    }
}