using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class monthly : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.Text != "Select.." && DropDownList2.Text != "Select..")
        {
            string month = DropDownList1.SelectedItem.ToString();
            string year = DropDownList2.SelectedItem.ToString();
            int yy = Convert.ToInt32(year);
            string monfirst = " ", monlast = " ";

            if (month == "January")
            {
                monfirst = "01";
                monlast = "31";

            }

            else if (month == "February" && yy % 4 == 0)
            {
                monfirst = "02";
                monlast = "29";
            }

            else if (month == "February")
            {
                monfirst = "02";
                monlast = "28";
            }

            else if (month == "March")
            {
                monfirst = "03";
                monlast = "31";
            }

            else if (month == "April")
            {
                monfirst = "04";
                monlast = "30";
            }

            else if (month == "May")
            {
                monfirst = "05";
                monlast = "31";
            }

            else if (month == "June")
            {
                monfirst = "06";
                monlast = "30";
            }

            else if (month == "July")
            {
                monfirst = "07";
                monlast = "31";
            }

            else if (month == "Auguest")
            {
                monfirst = "08";
                monlast = "31";
            }
            else if (month == "September")
            {
                monfirst = "09";
                monlast = "30";
            }

            else if (month == "October")
            {
                monfirst = "10";
                monlast = "31";
            }
            else if (month == "November")
            {
                monfirst = "11";
                monlast = "30";
            }
            else if (month == "December")
            {
                monfirst = "12";
                monlast = "31";
            }

            TextBox1.Text = year.ToString() + "-" + monfirst.ToString() + "-" + "01";
            TextBox2.Text = year.ToString() + "-" + monfirst.ToString() + "-" + monlast.ToString();


            Session["mdate1"] = TextBox1.Text.ToString();
            Session["mdate2"] = TextBox2.Text.ToString();
            Response.Redirect("monthlyreport.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("report.aspx");
    }
}