using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalvarySouthside;

namespace Admin
{
    public partial class People : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadPeople();
        }

        private void LoadPeople()
        {
            if (IsPostBack)
                return;

            dgPeople.DataSource = Person.GetAll();
            dgPeople.DataBind();
        }
    }
}