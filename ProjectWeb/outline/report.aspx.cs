using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string value;
        value=DropDownList_select_catagori.SelectedValue;

        if (value=="Daily")
        {
            Response.Redirect("daily.aspx");
        }

        else if (value == "Between Two Date")
        {
            Response.Redirect("btn2date.aspx");
        }

        else if (value == "Monthly")
        {
            Response.Redirect("monthly.aspx");
        }

        else if (value == "According To Plate No.")
        {
            Response.Redirect("plate.aspx");
        }
    }
}