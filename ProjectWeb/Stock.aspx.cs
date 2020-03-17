using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

public partial class Stock : System.Web.UI.Page
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
            string strVal = fr.rfirstRow("details");

            getValue gv = new getValue();
            double dbValue = gv.getInfo(strVal, "stock");

            tbQuantity.Text = dbValue.ToString();
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

    protected void ddlItem_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        string strItem = ddlItem.Text;

        getValue gv = new getValue();
        double dbValue = gv.getInfo(strItem, "stock");

        tbQuantity.Text = dbValue.ToString();
    }
}