using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shamim_platemonthly : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = Session["mpno"].ToString();
        TextBox2.Text = Session["fdate"].ToString();
        TextBox3.Text = Session["ldate"].ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("platemonthly1.aspx");
    }
}