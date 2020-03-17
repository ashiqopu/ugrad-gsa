using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace rabinSoft
{
    public partial class FormConfirm : Form
    {
        ConnectDB obj = new ConnectDB();

        string rSaler = "rabin"; // by default

        public FormConfirm(int addHit, string strCustomer, string strPlate, string strSalesman, string strTotal, string strPay, string strDue)
        {
            InitializeComponent();
            rSaler = strSalesman;

            lSalesman.Text = strSalesman;
            dataCount dc = new dataCount();
            int intCount = dc.rowCount("usage") + 1;
            lTransation.Text = intCount.ToString();

            lCustomer.Text = strCustomer;
            lPlate.Text = strPlate;

            if (strPay.Length == 0) strPay = "0";
            if (strDue.Length == 0) strDue = "0";
            lTotal.Text = strTotal;
            lPay.Text = strPay;
            lDue.Text = strDue;
        }

        private void FormConfirm_Load(object sender, EventArgs e)
        {
            SqlConnection con = obj.ConnectSQL();

            try
            {
                con.Open();
                SqlCommand select = new SqlCommand();
                select.Connection = con;

                DataTable dataset = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("select * from tempItem",con);
                sda.Fill(dataset);
                dgvItem.DataSource = dataset;
            }
            catch (SqlException ex)
            {
                string errorMsg = "Error : Check & Try Again Please...";
                errorMsg += ex.Message;
                throw new Exception(errorMsg);
            }
            finally
            {
                con.Close();
            }

            ToolTip_Hover();
        }

        private void ToolTip_Hover()
        {
            ToolTip msgToolTip = new ToolTip();
            msgToolTip.ToolTipIcon = ToolTipIcon.Info;
            msgToolTip.IsBalloon = true;
            msgToolTip.ShowAlways = true;
            msgToolTip.SetToolTip(bEdit, "Click Here To Cancel Transation.");
            msgToolTip.SetToolTip(bOk, "Click Here To Transation.");
            msgToolTip.SetToolTip(bExit, "Click Here To Exit Application.");
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEntry rabin = new FormEntry();
            rabin.ShowDialog();
            this.Close();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Want To Exit ? ", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            int rCount = 0;

            string[] itemArray = new string[39];
            string[] quantityArray = new string[39];
            string[] amountArray = new string[39];

            double[] insertQuantity = new double[39];
         
            string dates = System.DateTime.Now.ToString("yyyy-MM-dd");
            string times = System.DateTime.Now.ToLongTimeString();

            SqlConnection con = obj.ConnectSQL();

            try
            {
                con.Open();
                SqlCommand select = new SqlCommand();
                select.Connection = con;
                SqlDataReader reader;

                dataCount dc = new dataCount();
                int intCount = dc.rowCount("usage") + 1;

                double dbTotal = System.Convert.ToDouble(lTotal.Text);
                double dbPay = System.Convert.ToDouble(lPay.Text);
                double dbDue = System.Convert.ToDouble(lDue.Text);

                select.CommandText = "insert into usage values ('" + intCount + "', N'" + lCustomer.Text + "', N'" + lPlate.Text + "', N'" + lSalesman.Text + "','" + dbTotal + "', '" + dbPay + "', '" + dbDue + "', '" + dates + "','" + times + "')";
                reader = select.ExecuteReader();
                reader.Close();

                select.CommandText = "select * from tempItem";
                reader = select.ExecuteReader();
                while (reader.Read())
                {
                    itemArray[rCount] = reader[1].ToString();
                    quantityArray[rCount] = reader[2].ToString();
                    amountArray[rCount] = reader[3].ToString();
                    rCount += 1;
                }
                reader.Close();                 
            }

            catch (SqlException ex)
            {
                string errorMsg = "Error : Check & Try Again Please...";
                errorMsg += ex.Message;
                throw new Exception(errorMsg);
            }

            finally
            {
                con.Close();
            }

            for (int i = 0; i < rCount; i++)
            {
                getValue gv = new getValue();

                double dbQuantity = gv.getInfo(itemArray[i], "stock");
                double boxQuantity = System.Convert.ToDouble(quantityArray[i]);

                insertQuantity[i] = dbQuantity - boxQuantity;
            }

            try
            {
                con.Open();
                SqlCommand select = new SqlCommand();
                select.Connection = con;
                SqlDataReader reader;

                for (int i = 0; i < rCount; i++)
                {
                    select.CommandText = "update details set stock = '" + insertQuantity[i] + "' where Items = N'" + itemArray[i] + "'";
                    reader = select.ExecuteReader();
                    reader.Close();

                    select.CommandText = "insert into ItemUsage values (N'" + lPlate.Text + "', N'" + itemArray[i] + "', '" + quantityArray[i] + "', '" + amountArray[i] + "', '" + dates + "','" + times + "')";
                    reader = select.ExecuteReader();
                    reader.Close();
                }

                select.CommandText = "select * from due where plate = N'" + lPlate.Text + "'";
                reader = select.ExecuteReader();
                if (reader.Read())
                {
                    double dbDue = System.Convert.ToDouble(reader[2].ToString());
                    double newDue = dbDue + System.Convert.ToDouble(lDue.Text);
                    reader.Close();
                    select.CommandText = "update due set due = '"+ newDue +"' where plate = N'"+lPlate.Text+"'";
                    reader = select.ExecuteReader();
                }
                else
                {
                    double newDue = System.Convert.ToDouble(lDue.Text);
                    reader.Close();
                    select.CommandText = "insert into due values (N'" + lPlate.Text + "', N'" + lCustomer.Text + "', '" + newDue + "')";
                    reader = select.ExecuteReader();
                }

                reader.Close();
            
            }

            catch (SqlException ex)
            {
                string errorMsg = "Error : Check & Try Again Please...";
                errorMsg += ex.Message;
                throw new Exception(errorMsg);
            }

            finally
            {
                con.Close();
            }

            //this.Hide();
            this.Close();         
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();
        }
    }
}
