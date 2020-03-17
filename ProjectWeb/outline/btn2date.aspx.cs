using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class btn2date : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "" || TextBox2.Text != "")
        {
            Session["date1"] = TextBox1.Text.ToString();
            Session["date2"] = TextBox2.Text.ToString();
            Response.Redirect("showbtn2datesreport.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("report.aspx");
    }
}