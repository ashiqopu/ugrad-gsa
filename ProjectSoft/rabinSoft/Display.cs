using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace rabinSoft
{
    public partial class FormDisplay : Form
    {
        ConnectDB obj = new ConnectDB();

        public FormDisplay()
        {
            InitializeComponent();

        }

        private void FormDisplay_Load(object sender, EventArgs e)
        {
            usb1.Visible = false;
            usb2.Visible = false;
        }

        private void deAllButton(Boolean str)
        {
            cbLt.Enabled = str;
            cbTk.Enabled = str;

            bTOT.Enabled = str;
            bESC.Enabled = str;
            bSET.Enabled = str;
            bINQ.Enabled = str;
            bCAL.Enabled = str;
            bSEL.Enabled = str;
            bPRI.Enabled = str;
            b0.Enabled = str;
            b1.Enabled = str;
            b2.Enabled = str;
            b3.Enabled = str;
            b4.Enabled = str;
            b5.Enabled = str;
            b6.Enabled = str;
            b7.Enabled = str;
            b8.Enabled = str;
            b9.Enabled = str;
            bdot.Enabled = str;
            bRES.Enabled = str;
            bOK.Enabled = str;
        }

        private void deButtonClick(char c, Boolean str)
        {
            if (c == '.') bdot.Enabled = str;
            else if (c == '0') b0.Enabled = str;
            else if (c == '1') b1.Enabled = str;
            else if (c == '2') b2.Enabled = str;
            else if (c == '3') b3.Enabled = str;
            else if (c == '4') b4.Enabled = str;
            else if (c == '5') b5.Enabled = str;
            else if (c == '6') b6.Enabled = str;
            else if (c == '7') b7.Enabled = str;
            else if (c == '8') b8.Enabled = str;
            else if (c == '9') b9.Enabled = str;
        }

        public void DisplayEntry()
        {
            ssaTk.Value = GV.GlobalTk.ToString();
            ssaLt.Value = GV.GlobalLt.ToString();

            if (GV.GlobalLt != 0 && GV.GlobalTk != 0)
            {
                usb1.Visible = true;
                usb2.Visible = true;
            }
            else
            {
                usb1.Visible = false;
                usb2.Visible = false;
            }

            if (GV.GlobalType.Equals("Tk") == true)
            {
                cbTk.Checked = true;
            }
            else if (GV.GlobalType.Equals("Lt") == true)
            {
                cbLt.Checked = true;
            }

            if (System.Convert.ToDouble(ssaTk.Value) != 0 && System.Convert.ToDouble(ssaLt.Value) != 0)
            {
                deAllButton(false);
            }
            else
            {
                deAllButton(true);
            }

            GV.GlobalTk = 0.0;
            GV.GlobalLt = 0.0;
        }

        private void cbTk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTk.Checked == true)
            {
                cbLt.Checked = false;
            }
            else
            {
                cbLt.Checked = true;
            }          
        }

        private void cbLt_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLt.Checked == true)
            {
                cbTk.Checked = false;
            }
            else
            {
                cbTk.Checked = true;
            }      
        }

        private void setValue(string bValue)
        {
            string ssaValue = "";

            if (cbTk.Checked == true && cbLt.Checked == false)
            {
                if (bValue.Equals(".") == false && ssaTk.Value.IndexOf(".") < 0)
                {
                    double dbValue = System.Convert.ToDouble(ssaTk.Value);
                    if (dbValue != 0)
                    {
                        ssaValue = System.Convert.ToString(dbValue);
                        ssaTk.Value = ssaValue + bValue;
                        ssaLt.Value = Math.Round((System.Convert.ToDouble(ssaTk.Value) / GV.GlobalUnit), 4).ToString();
                    }
                    else
                    {
                        ssaTk.Value = bValue;
                        ssaLt.Value = Math.Round((System.Convert.ToDouble(ssaTk.Value) / GV.GlobalUnit), 4).ToString();
                    }
                }
                else
                {
                    ssaValue = ssaTk.Value;
                    ssaTk.Value = ssaValue + bValue;
                    ssaLt.Value = Math.Round((System.Convert.ToDouble(ssaTk.Value) / GV.GlobalUnit), 4).ToString();
                }
            }
            else
            {
                if (bValue.Equals(".") == false && ssaLt.Value.IndexOf(".") < 0)
                {
                    double dbValue = System.Convert.ToDouble(ssaLt.Value);
                    if (dbValue != 0)
                    {
                        ssaValue = System.Convert.ToString(dbValue);
                        ssaLt.Value = ssaValue + bValue;
                        ssaTk.Value = Math.Round((System.Convert.ToDouble(ssaLt.Value) * GV.GlobalUnit), 4).ToString();
                    }
                    else
                    {
                        ssaLt.Value = bValue;
                        ssaTk.Value = Math.Round((System.Convert.ToDouble(ssaLt.Value) * GV.GlobalUnit), 4).ToString();
                    }
                }
                else
                {
                    ssaValue = ssaLt.Value;
                    ssaLt.Value = ssaValue + bValue;
                    ssaTk.Value = Math.Round((System.Convert.ToDouble(ssaLt.Value) * GV.GlobalUnit), 4).ToString();
                }
            }

            if (System.Convert.ToDouble(ssaTk.Value) != 0 && System.Convert.ToDouble(ssaLt.Value) != 0)
            {
                GV.GlobalTk = System.Convert.ToDouble(ssaTk.Value);
                GV.GlobalLt = System.Convert.ToDouble(ssaLt.Value);
            }
            else
            {
                GV.GlobalTk = 0.0;
                GV.GlobalLt = 0.0;
            }

            if (GV.GlobalStock < GV.GlobalLt)
            {
                cbLt.ForeColor = Color.Red;

                GV.GlobalTk = 0.0;
                GV.GlobalLt = 0.0;
                ssaTk.Value = "0";
                ssaLt.Value = "0";

                MessageBox.Show("Stock Exceed ...", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bRES_Click(object sender, EventArgs e)
        {
            cbTk.ForeColor = Color.Black;
            cbLt.ForeColor = Color.Black;

            GV.GlobalTk = 0.0;
            GV.GlobalLt = 0.0;
            ssaTk.Value = "0";
            ssaLt.Value = "0";

            cbLt.Checked = true;
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            if (cbTk.Checked == true && cbLt.Checked == false)
            {
                if (ssaTk.Value.IndexOf(".") < 0)
                {
                    setValue(".");
                }
            }
            else
            {
                if (ssaLt.Value.IndexOf(".") < 0)
                {
                    setValue(".");
                }
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            setValue("0");
        }

        private void b1_Click(object sender, EventArgs e)
        {
            setValue("1");
        }

        private void b2_Click(object sender, EventArgs e)
        {
            setValue("2");
        }

        private void b3_Click(object sender, EventArgs e)
        {
            setValue("3");
        }

        private void b4_Click(object sender, EventArgs e)
        {
            setValue("4");
        }

        private void b5_Click(object sender, EventArgs e)
        {
            setValue("5");
        }

        private void b6_Click(object sender, EventArgs e)
        {
            setValue("6");
        }

        private void b7_Click(object sender, EventArgs e)
        {
            setValue("7");
        }

        private void b8_Click(object sender, EventArgs e)
        {
            setValue("8");
        }

        private void b9_Click(object sender, EventArgs e)
        {
            setValue("9");
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            double chkQuantity = 0.0;
            double chkAmount = 0.0;

            if (ssaLt.Value.Equals("") == false && ssaLt.Value.Equals(".") == false)
                chkQuantity = System.Convert.ToDouble(ssaLt.Value);

            if (ssaTk.Value.Equals("") == false && ssaTk.Value.Equals(".") == false)
                chkAmount = System.Convert.ToDouble(ssaTk.Value);

            if (chkQuantity != 0 && chkAmount != 0 && GV.GlobalStock > chkQuantity)
            {
                int tempCount = 0;

                SqlConnection con = obj.ConnectSQL();

                try
                {
                    con.Open();
                    SqlCommand select = new SqlCommand();
                    select.Connection = con;
                    SqlDataReader reader;

                    dataCount dcTemp = new dataCount();
                    tempCount = dcTemp.rowCount("tempItem") + 1;

                    select.CommandText = "insert into tempItem values ('" + tempCount + "', N'" + GV.GlobalItem + "', '" + chkQuantity + "', '" + chkAmount + "')";
                    reader = select.ExecuteReader();
                    reader.Close();

                    int hitAdd = GV.GlobalAdd;
                    GV.GlobalAdd = hitAdd + 1;

                    double hitTotal = GV.GlobalTotal;
                    GV.GlobalTotal = hitTotal + chkAmount;

                    ssaTk.Value = "0";
                    ssaLt.Value = "0";

                    GV.GlobalTk = 0.0;
                    GV.GlobalLt = 0.0;
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

                //this.Close();
            }
            else
            {
                if (chkQuantity == 0)
                {
                    cbLt.ForeColor = Color.Red;
                }

                if (chkAmount == 0)
                {
                    cbTk.ForeColor = Color.Red;
                }
                MessageBox.Show("Ensure Necessary Field(s) ...", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
