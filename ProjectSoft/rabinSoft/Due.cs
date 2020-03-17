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
    public partial class FormDue : Form
    {
        ConnectDB obj = new ConnectDB();

        int countDot = 0;

        public FormDue(string strCustomer, string strPlate)
        {
            InitializeComponent();

            tbCustomer.Text = strCustomer;
            tbPlate.Text = strPlate;

            tbCustomer.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_Name);
            tbPlate.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_Name);
            tbAmount.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithDot);
        }

        private void validTextBox_KeyPress_Name(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '.' || e.KeyChar == ' ' || e.KeyChar == '-' || e.KeyChar == ',' || e.KeyChar == '_' || e.KeyChar == '(' || e.KeyChar == ')')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void validTextBox_KeyPress_WithDot(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void validTextBox_KeyPress_WithOutDot(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void validTextBox_KeyPress_WithOutAny(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void Due_Load(object sender, EventArgs e)
        {
            tbCustomer.TextAlign = HorizontalAlignment.Center;
            tbPlate.TextAlign = HorizontalAlignment.Center;
            tbAmount.TextAlign = HorizontalAlignment.Center;

            tbAmount.Text = "0";
            funDue(tbCustomer.Text, tbPlate.Text);
            ToolTip_Hover();
        }

        private void ToolTip_Hover()
        {
            ToolTip msgToolTip = new ToolTip();
            msgToolTip.ToolTipIcon = ToolTipIcon.Info;
            msgToolTip.IsBalloon = true;
            msgToolTip.ShowAlways = true;
            msgToolTip.SetToolTip(bHistory, "Click Here To See Pay History.");
            msgToolTip.SetToolTip(bUpdate, "Click Here To Update Due.");
            msgToolTip.SetToolTip(bClose, "Click Here To Close This Window.");
            msgToolTip.SetToolTip(bReset, "Click Here To Reset.");
            msgToolTip.SetToolTip(bExit, "Click Here To Exit Application.");
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            //this.Hide();
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

        private void tbCustomer_TextChanged(object sender, EventArgs e)
        {
            string strCustomer = tbCustomer.Text;
            string strPlate = tbPlate.Text;
            funDue(strCustomer, strPlate);
        }

        private void tbPlate_TextChanged(object sender, EventArgs e)
        {
            lPlate.ForeColor = Color.Black;
            string strCustomer = tbCustomer.Text;
            string strPlate = tbPlate.Text;
            funDue(strCustomer, strPlate);
        }

        private void funDue(string strCustomer, string strPlate)
        {
            SqlConnection con = obj.ConnectSQL();

            try
            {
                con.Open();
                SqlCommand select = new SqlCommand();
                select.Connection = con;

                string strQuery = "select * from due where due != '0'";

                if (strCustomer.Length == 0 && strPlate.Length != 0)
                    strQuery = "select * from due where due != '0' and plate=N'" + strPlate + "'";
                else if (strCustomer.Length != 0 && strPlate.Length == 0)
                    strQuery = "select * from due where due != '0' and customer=N'" + strCustomer + "'";
                else if (strCustomer.Length != 0 && strPlate.Length != 0)
                    strQuery = "select * from due where due != '0' and plate=N'" + strPlate + "' and customer=N'" + strCustomer + "'";
                

                DataTable dataset = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(strQuery, con);
                sda.Fill(dataset);
                dgvDue.DataSource = dataset;
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

        private void bUpdate_Click(object sender, EventArgs e)
        {
            string dates = System.DateTime.Now.ToString("yyyy-MM-dd");
            string times = System.DateTime.Now.ToLongTimeString();

            double boxAmount = 0.0;

            if(tbAmount.Text.Length > 0 && tbAmount.Equals(".") == false)
                boxAmount = System.Convert.ToDouble(tbAmount.Text);

            if (tbPlate.Text.Length > 0 && boxAmount != 0)
            {
                SqlConnection con = obj.ConnectSQL();

                try
                {
                    con.Open();
                    SqlCommand select = new SqlCommand();
                    select.Connection = con;
                    SqlDataReader reader;

                    dataCount dc = new dataCount();
                    int intCount = dc.rowCount("duePay") + 1;

                    select.CommandText = "insert into duePay values ('" + intCount + "', N'" + tbPlate.Text + "', N'" + tbCustomer.Text + "','" + boxAmount + "', '" + dates + "','" + times + "')";
                    reader = select.ExecuteReader();
                    reader.Close();

                    select.CommandText = "select * from due where plate = N'" + tbPlate.Text + "'";
                    reader = select.ExecuteReader();
                    if (reader.Read())
                    {
                        double dbDue = System.Convert.ToDouble(reader[2].ToString());
                        double newDue = dbDue - System.Convert.ToDouble(tbAmount.Text);
                        reader.Close();
                        select.CommandText = "update due set due = '" + newDue + "' where plate = N'" + tbPlate.Text + "'";
                        reader = select.ExecuteReader();
                    }
                    reader.Close();

                    tbAmount.Text = "0";
                    funDue(tbCustomer.Text,tbPlate.Text);

                    //this.Hide();
                    FormDueHistory rabin = new FormDueHistory(tbCustomer.Text, tbPlate.Text);
                    rabin.ShowDialog();
                    //this.Close();

                    funDue(tbCustomer.Text, tbPlate.Text);
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
            else
            {
                if (tbPlate.Text.Length == 0)
                {
                    lPlate.ForeColor = Color.Red;
                }

                if (boxAmount == 0)
                {
                    lTk.ForeColor = Color.Red;
                }

                MessageBox.Show("Please Ensure Required Field ...", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            lTk.ForeColor = Color.Black;
            string strValue = tbAmount.Text;
            DotCheckFunction(strValue);
            Dot2PFunction(strValue);

            double dbDue = 0.0;
            double boxPay = 0.0;
            if (strValue.Equals("") == false && strValue.Equals(".") == false)
            {
                boxPay = System.Convert.ToDouble(strValue);
            }

            SqlConnection con = obj.ConnectSQL();

            try
            {
                con.Open();
                SqlCommand select = new SqlCommand();
                select.Connection = con;

                select.CommandText = "select * from due where plate = N'" + tbPlate.Text + "'";
                SqlDataReader reader = select.ExecuteReader();

                if (reader.Read())
                {
                    dbDue = System.Convert.ToDouble(reader[2].ToString());
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

            if (boxPay > dbDue)
            {
                MessageBox.Show("Amount exceeded ...", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAmount.Text = "0";
            }
        }

        public void DotCheckFunction(string strDot)
        {
            if (strDot.IndexOf(".") < 0)
            {
                countDot = 0;
            }

            for (int i = 0; i < strDot.Length; i++)
            {
                if (strDot[i] == '.')
                {
                    countDot = 1;
                    break;
                }
            }

            if (countDot == 1)
            {
                tbAmount.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithOutDot);
            }
            else
            {
                tbAmount.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithDot);
            }
        }

        private void Dot2PFunction(string strValue)
        {
            if (strValue.IndexOf(".") > -1)
            {
                if (strValue.Length - strValue.IndexOf(".") == 3)
                {
                     tbAmount.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithOutAny);
                }
            }
        }

        private void tbAmount_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPlate.Text.Length != 0)
            {
                double boxAmount = 0.0;

                if (tbAmount.Text.Length > 0 && tbAmount.Equals(".") == false)
                    boxAmount = System.Convert.ToDouble(tbAmount.Text);

                if (boxAmount == 0)
                {
                    tbAmount.Text = "";
                }
            }
            else
            {
                lPlate.ForeColor = Color.Red;
                MessageBox.Show("Plate Not Found...", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bHistory_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormDueHistory rabin = new FormDueHistory(tbCustomer.Text,tbPlate.Text);
            rabin.ShowDialog();
            //this.Close();

            funDue(tbCustomer.Text, tbPlate.Text);
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            lPlate.ForeColor = Color.Black;
            lTk.ForeColor = Color.Black;
            tbCustomer.Text = "";
            tbPlate.Text = "";
            tbAmount.Text = "0";
        }    
    }
}
