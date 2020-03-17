using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class Edit : System.Web.UI.Page
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
            double dbValue = gv.getInfo(strVal, "price");

            TextBoxPrice.Text = dbValue.ToString();

            strVal = fr.rfirstRow("salesperson");
            string strValue = gv.getPass(strVal, "password");

            TextBoxPass.Text = strValue;
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

    protected void bUpdatePrice_Click(object sender, EventArgs e)
    {
        string strValue = TextBoxPrice.Text;

        if (strValue.Equals("") == false && strValue.Equals(".") == false)
        {
            string strItem = ddlPrice.Text;

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

                    select.CommandText = "update details set sell = '" + dbValue + "' where items = N'" + strItem + "'";
                    select.ExecuteNonQuery();

                    select.Clone();
                    con.Close();

                    Response.Redirect("Edit.aspx");
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

    protected void ddlPrice_SelectedIndexChanged(object sender, EventArgs e)
    {
        string strItem = ddlPrice.Text;

        getValue gv = new getValue();
        double dbValue = gv.getInfo(strItem, "price");
        TextBoxPrice.Text = dbValue.ToString();
    }

    protected void bUpdateSales_Click(object sender, EventArgs e)
    {
        string strSales = ddlSales.Text;
        string strPass = TextBoxPass.Text;

        if (strPass.Equals("") == false)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                con.Open();

                SqlCommand select = new SqlCommand();
                select.Connection = con;

                select.CommandText = "update login set password = '" + strPass + "' where username = N'" + strSales + "' and type = 'salesman'";
                select.ExecuteNonQuery();

                select.Clone();
                con.Close();

                Response.Redirect("Edit.aspx");
            }
            catch (SqlException ex)
            {
                string errorMsg = "Error : Check & Try Again Please...";
                errorMsg += ex.Message;
                throw new Exception(errorMsg);
            }
        }
    }

    protected void ddlSales_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string strUser = ddlSales.Text;
            string strPass = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            con.Open();

            SqlCommand select = new SqlCommand();
            select.Connection = con;

            select.CommandText = "select * from login where username = N'" + strUser + "' and type = 'salesman'";
            SqlDataReader reader = select.ExecuteReader();

            if (reader.Read())
            {
                strPass = reader[1].ToString();
                TextBoxPass.Text = strPass;
            }

            reader.Close();
            con.Close();
        }

        catch (SqlException ex)
        {
            string errorMsg = "Error : Check & Try Again Please...";
            errorMsg += ex.Message;
            throw new Exception(errorMsg);
        }
    }

    protected void bAddSales_Click(object sender, EventArgs e)
    {
        if (tbAddUser.Text.Equals("") == false && tbAddPass.Text.Equals("") == false)
        {
            try
            {
                string strUser = tbAddUser.Text;
                string strPass = tbAddPass.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                con.Open();

                SqlCommand select = new SqlCommand();
                select.Connection = con;

                select.CommandText = "select * from login where username = '" + strUser + "' and type = 'salesman'";
                SqlDataReader reader = select.ExecuteReader();

                int flag = 0;
                if (reader.Read())
                {
                    flag = 1;
                }
                reader.Close();

                if (flag == 0)
                {
                    select.CommandText = "insert into login values (N'" + strUser + "','" + strPass + "','salesman')";
                    reader = select.ExecuteReader();
                    reader.Close();
                }
                else
                {
                    string script = "alert(\"Duplicate :  Name Already Exists ...\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }

                con.Close();

                Response.Redirect("Edit.aspx");
            }

            catch (SqlException ex)
            {
                string errorMsg = "Error : Check & Try Again Please...";
                errorMsg += ex.Message;
                throw new Exception(errorMsg);
            }
        }
        else
        {
            string script = "alert(\"Please Fill Required Field ...\");";
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        }
    }

    protected void bAddItem_Click(object sender, EventArgs e)
    {
        if (tbAddItem.Text.Equals("") == false && tbAddPrice.Text.Equals("") == false)
        {
            try
            {
                string strItem = tbAddItem.Text;
                string strPrice = tbAddPrice.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                con.Open();

                SqlCommand select = new SqlCommand();
                select.Connection = con;

                select.CommandText = "select * from details where items = N'" + strItem + "'";
                SqlDataReader reader = select.ExecuteReader();

                int flag = 0;
                if (reader.Read())
                {
                    flag = 1;
                }
                reader.Close();

                if (flag == 0)
                {
                    double dbPrice = System.Convert.ToDouble(strPrice);
                    dbPrice = Math.Round(dbPrice, 4);
                    strPrice = System.Convert.ToString(dbPrice);
                    double dbOthers = 0;

                    select.CommandText = "insert into details values (N'" + strItem + "','" + dbOthers + "','" + dbPrice + "','" + dbOthers + "')";
                    reader = select.ExecuteReader();
                    reader.Close();
                }
                else
                {
                    string script = "alert(\"Duplicate :  Name Already Exists ...\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }

                con.Close();

                Response.Redirect("Edit.aspx");
            }

            catch (SqlException ex)
            {
                string errorMsg = "Error : Check & Try Again Please...";
                errorMsg += ex.Message;
                throw new Exception(errorMsg);
            }
        }
        else
        {
            string script = "alert(\"Please Fill Required Field ...\");";
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        }
    }

    protected void bCancelSales_Click(object sender, EventArgs e)
    {
        dataCount dc = new dataCount();
        int intCount = dc.rowCount("salesman");

        fCancle(intCount, "salesman");
    }

    protected void bCancelItem_Click(object sender, EventArgs e)
    {
        dataCount dc = new dataCount();
        int intCount = dc.rowCount("details");

        fCancle(intCount, "details");
    }

    private void fCancle(int intCount, string strTry)
    {
        if (intCount > 0)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                con.Open();

                SqlCommand select = new SqlCommand();
                select.Connection = con;

                if (strTry.Equals("salesman") == true)
                    select.CommandText = "select * from login where type = 'salesman'";
                else if (strTry.Equals("details") == true)
                    select.CommandText = "select * from details";

                SqlDataReader reader = select.ExecuteReader();

                int intChk = 0;
                string strChk = "";
                int flag = 0;
                while (reader.Read())
                {
                    intChk += 1;
                    if (intChk == intCount)
                    {
                        strChk = reader[0].ToString();
                        flag = 1;
                    }
                }
                reader.Close();

                if (flag == 1)
                {
                    if (strTry.Equals("salesman") == true)
                        select.CommandText = "delete from login where username =N'" + strChk + "' and type = 'salesman'";
                    else if (strTry.Equals("details") == true)
                        select.CommandText = "delete from details where items =N'" + strChk + "'";
                    select.ExecuteNonQuery();
                    select.Clone();
                }

                con.Close();

                Response.Redirect("Edit.aspx");
            }

            catch (SqlException ex)
            {
                string errorMsg = "Error : Check & Try Again Please...";
                errorMsg += ex.Message;
                throw new Exception(errorMsg);
            }
        }
        else
        {
            string script = "alert(\"Nothing To Cancel ...\");";
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        }
    }
}