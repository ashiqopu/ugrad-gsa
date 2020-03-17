using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class daily : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "")
        {
            Session["date"] = TextBox1.Text.ToString();
            Response.Redirect("showdailyreport.aspx");
        }      
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("report.aspx");
    }
}