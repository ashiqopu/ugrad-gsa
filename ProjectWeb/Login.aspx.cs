using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            HttpCookie userCookie;
            userCookie = Request.Cookies["Preferences"];

            if (userCookie != null)
            {
                if (!userCookie.Value.Equals(-1))
                {
                    Session.Clear();
                    Session["Login"] = Login1.UserName.ToString();
                    Response.Redirect("Usage.aspx");
                }
            }
            if (Session["Login"] != null)
            {
                Response.Redirect("Usage.aspx");
            }
    }

    protected void Login_Authenticate(object sender, AuthenticateEventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            con.Open();

            SqlCommand select = new SqlCommand();
            select.Connection = con;

            select.CommandText = "select username from login where username = N'" + Login1.UserName.ToString() + "' and password = '" + Login1.Password.ToString() + "' ";

            SqlDataReader reader = select.ExecuteReader();

            if (reader.Read())
            {
                Session["Login"] = Login1.UserName.ToString();

                if (Login1.RememberMeSet == true)
                {
                    HttpCookie userCookie;
                    userCookie = Request.Cookies["Preferences"];

                    if (userCookie == null)
                    {
                        userCookie = new HttpCookie("Preferences");
                        userCookie.Expires = DateTime.Now.AddMonths(1);
                        Response.Cookies.Add(userCookie);
                    }
                }

                Response.Redirect("Usage.aspx");
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

}
