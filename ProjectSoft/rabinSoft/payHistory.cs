using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rabinSoft
{
    public partial class FormDueHistory : Form
    {
        ConnectDB obj = new ConnectDB();

        string Customer = "";
        string Plate = "";

        public FormDueHistory(string strCustomer, string strPlate)
        {
            InitializeComponent();
            Customer = strCustomer;
            Plate = strPlate;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to cancel your last update ?", "Cancel : ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataCount dc = new dataCount();
                int intCount = dc.rowCount("duePay");
                if (intCount > 0)
                {
                    SqlConnection con = obj.ConnectSQL();

                    try
                    {
                        con.Open();
                        SqlCommand select = new SqlCommand();
                        select.Connection = con;

                        string dbPlate = "0";
                        string dbPay = "0";
                        string dbDue = "0";

                        select.CommandText = "select * from duePay where serial='" + intCount + "'";
                        SqlDataReader reader = select.ExecuteReader();

                        if (reader.Read())
                        {
                            dbPlate = reader[1].ToString();
                            dbPay = reader[3].ToString();
                            reader.Close();

                            select.CommandText = "select * from due where plate = N'" + dbPlate + "'";
                            reader = select.ExecuteReader();
                            if (reader.Read())
                            {
                                dbDue = reader[2].ToString();
                            }
                            reader.Close();

                            double totalValue = System.Convert.ToDouble(dbDue) + System.Convert.ToDouble(dbPay);

                            select.CommandText = "update due set due = '" + totalValue + "' where plate = N'" + dbPlate + "'";

                            select.ExecuteNonQuery();
                        }

                        select.CommandText = "delete from duePay where serial ='" + intCount + "'";
                        select.ExecuteNonQuery();

                        select.Clone();
                        con.Close();

                        funHistory();
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
                    MessageBox.Show("Nothing To Cancel ...", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
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

        private void bClose_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FormDue rabin = new FormDue(Customer, Plate);
            //rabin.ShowDialog();
            this.Close();
        }

        private void FormDueHistory_Load(object sender, EventArgs e)
        {
            funHistory();
            ToolTip_Hover();
        }

        private void ToolTip_Hover()
        {
            ToolTip msgToolTip = new ToolTip();
            msgToolTip.ToolTipIcon = ToolTipIcon.Info;
            msgToolTip.IsBalloon = true;
            msgToolTip.ShowAlways = true;
            msgToolTip.SetToolTip(bCancel, "Click Here To Cancel Your Last Update.");
            msgToolTip.SetToolTip(bClose, "Click Here To Close This Window.");
            msgToolTip.SetToolTip(bExit, "Click Here To Exit Application.");
        }

        private void funHistory()
        {
            SqlConnection con = obj.ConnectSQL();

            try
            {
                con.Open();
                SqlCommand select = new SqlCommand();
                select.Connection = con;

                string strQuery = "select * from duePay order by serial DESC";

                if (Customer.Length == 0 && Plate.Length != 0)
                { strQuery = "select * from duePay where Plate = '" + Plate + "' order by serial DESC"; }
                else if (Customer.Length != 0 && Plate.Length == 0)
                { strQuery = "select * from duePay where Customer = '" + Customer + "' order by serial DESC"; }
                else if (Customer.Length != 0 && Plate.Length != 0)
                { strQuery = "select * from duePay where Customer = '" + Customer + "' and  Plate = '" + Plate + "' order by serial DESC"; }

                DataTable dataset = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(strQuery, con);
                sda.Fill(dataset);
                dgvHistory.DataSource = dataset;
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
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDue rabin = new FormDue(Customer, Plate);
            rabin.ShowDialog();
            this.Close();
        }
    }
}
