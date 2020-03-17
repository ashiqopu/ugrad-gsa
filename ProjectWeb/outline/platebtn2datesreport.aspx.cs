using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shamim_platebtn2datesreport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox2.Text = Session["date1"].ToString();
        TextBox3.Text = Session["date2"].ToString();
        TextBox1.Text = Session["plateno"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("platebtn2dates.aspx");
    }
}