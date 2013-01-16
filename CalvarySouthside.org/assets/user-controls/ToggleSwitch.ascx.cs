using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class assets_user_controls_ToggleSwitch : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DisplayValue();
    }

    public bool Checked
    {
        get {
            return hdnToggleSwitch.Value == "true";
        }
        set {
            hdnToggleSwitch.Value = value.ToString();
            DisplayValue();
        }
    }

    private void DisplayValue()
    {
        if (Checked)
        {
            hlnkToggleSwitch.CssClass = "ToggleSwitchOn";
            hlnkToggleSwitch.Attributes["style"] = "left: 0;";
        }
        else {
            hlnkToggleSwitch.CssClass = "ToggleSwitchOff";
            hlnkToggleSwitch.Attributes["style"] = "left: -25px;";
        }
        
    }
}