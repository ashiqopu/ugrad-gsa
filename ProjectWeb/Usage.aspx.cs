using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Usage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            Response.ClearHeaders();
            Response.AddHeader("Cache-Control", "no-store, no-cache, must-revalidate");
            Response.AddHeader("Pragma", "no-cache");
        }

        if (!IsPostBack)
        {
            firstRow fr = new firstRow();
            ddlItem.Text = fr.rfirstRow("details");
            TextBoxC1.Text = DateTime.Now.ToString("yyyy-MM-dd");
            TextBoxC2.Text = DateTime.Now.ToString("yyyy-MM-dd");

            gvAll.Visible = true;
            gvUsage.Visible = false;
            gvAll.DataBind();
        }
    }
    protected void ButtonLogout_Click(object sender, EventArgs e)
    {
        Session.Clear();

        HttpCookie myCookie = new HttpCookie("Preferences");
        myCookie.Expires = DateTime.Now.AddDays(-1d);
        Response.Cookies.Add(myCookie);
      
        Response.Redirect("Login.aspx");
    }

    protected void bOk_Click(object sender, EventArgs e)
    {
        if (TextBoxC1.Text.Equals("") == false && TextBoxC2.Text.Equals("") == false)
        {
            gvAll.Visible = false;
            gvUsage.Visible = true;
            gvUsage.DataBind();
        }
    }
    protected void bsAll_Click(object sender, EventArgs e)
    {
        gvAll.Visible = true;
        gvUsage.Visible = false;
        gvAll.DataBind();
    }
}