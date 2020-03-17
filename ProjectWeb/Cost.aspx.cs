using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cost : System.Web.UI.Page
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
            string strVal = "";
            firstRow fr = new firstRow();
            getValue gv = new getValue();

            strVal = fr.rfirstRow("details");
            double dbValue = gv.getInfo(strVal, "cost");

            TextBoxCost.Text = dbValue.ToString();
        }
    }

    protected void ddlCost_SelectedIndexChanged(object sender, EventArgs e)
    {
        string strItem = ddlCost.Text;

        getValue gv = new getValue();
        double dbValue = gv.getInfo(strItem, "cost");
        TextBoxCost.Text = dbValue.ToString();
    }

    protected void bUpdateCost_Click(object sender, EventArgs e)
    {
        string strValue = TextBoxCost.Text;

        if (strValue.Equals("") == false && strValue.Equals(".") == false)
        {
            string strItem = ddlCost.Text;

            double dbValue = System.Convert.ToDouble(strValue);
            dbValue = Math.Round(dbValue, 4);

            if (dbValue != 0)
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                    con.Open();

                    SqlCommand select = new SqlCommand();
                    select.Connection = con;

                    select.CommandText = "update details set buy = '" + dbValue + "' where items = N'" + strItem + "'";
                    select.ExecuteNonQuery();

                    select.Clone();
                    con.Close();
                }

                catch (SqlException ex)
                {
                    string errorMsg = "Error : Check & Try Again Please...";
                    errorMsg += ex.Message;
                    throw new Exception(errorMsg);
                }
            }
        }
    }
}