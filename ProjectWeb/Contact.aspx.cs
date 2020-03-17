using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            string name = String.Format("{0}", TextBoxName.Text);
            string email = String.Format("{0}", TextBoxEmail.Text);
            string age = String.Format("{0}", TextBoxAge.Text);
            string gender = String.Format("{0}", DropDownListGender.Text);
            string feedback = String.Format("{0}", TextBoxFeedback.Text);
            string dates = System.DateTime.Now.ToString("dd - MM - yyyy");
            string times = System.DateTime.Now.ToLongTimeString();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            con.Open();

            SqlCommand select = new SqlCommand();
            select.Connection = con;

            select.CommandText = "select * from feedback";

            SqlDataReader reader = select.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            count = count + 1;
            reader.Close();

            select.CommandText = "insert into feedback values (" + count + ", '" + name + "' ,'" + email + "','" + age + "' ,'" + gender + "','" + feedback + "' ,'" + dates + "','" + times + "')";

            reader = select.ExecuteReader();

            reader.Close();
            con.Close();
            Response.Redirect("Contact.aspx");
        }
        catch (SqlException ex)
        {
            string errorMsg = "Error : Check & Try Again Please...";
            errorMsg += ex.Message;
            throw new Exception(errorMsg);
        }
    }
}