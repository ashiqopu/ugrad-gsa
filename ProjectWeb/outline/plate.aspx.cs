using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class plate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string choice;
        choice = DropDownList1.SelectedItem.ToString();

        if (choice == "Daily")
        {
            Response.Redirect("platedaily1.aspx");
        }

        else if (choice== "Between Two Dates")
        {
            Response.Redirect("platebtn2dates.aspx");
        }

        else if (choice == "Monthly")
        {
            Response.Redirect("platemonthly1.aspx");
        }
        else if (choice == "Yearly")
        {
            Response.Redirect("plateYearly.aspx");
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("report.aspx");
    }
}