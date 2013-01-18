using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalvarySouthside.Forms;

public partial class admin_default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadMessages();
    }

    private void LoadMessages()
    {
        List<Message> messages = Message.GetLatest();

        lvMessages.DataSource = messages;
        lvMessages.DataBind();

        int x = 0;
    }
}