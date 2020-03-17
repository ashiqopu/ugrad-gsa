using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shamim_platebtn2dates : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "")
        {
            Session["date1"] = TextBox1.Text.ToString();
            Session["date2"] = TextBox2.Text.ToString();
            Session["plateno"] = TextBox3.Text.ToString();
            Response.Redirect("platebtn2datesreport.aspx");
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("plate.aspx");
    }
}