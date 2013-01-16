using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalvarySouthside;

public partial class bible_study_default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadBibleStudies();
    }

    private void LoadBibleStudies()
    {
        if (IsPostBack)
            return;

        List<BibleStudy> bibleStudy = BibleStudy.GetLatest();
        lvBibleStudy.DataSource = bibleStudy;
        lvBibleStudy.DataBind();
    }
}