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
    public partial class FormCost : Form
    {
        ConnectDB obj = new ConnectDB();

        int countDot = 0;
        int countType = 0;

        public FormCost()
        {
            InitializeComponent();

            cbOthers.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_Name);
            tbQuantity.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithDot);
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


        private void FormCost_Load(object sender, EventArgs e)
        {
            this.detailsTableAdapter.Fill(this.costDataSet.details);

            tbQuantity.TextAlign = HorizontalAlignment.Center;
            tbAmount.TextAlign = HorizontalAlignment.Center;

            fuSet();
            ToolTip_Hover();
        }

        private void ToolTip_Hover()
        {
            ToolTip msgToolTip = new ToolTip();
            msgToolTip.ToolTipIcon = ToolTipIcon.Info;
            msgToolTip.IsBalloon = true;
            msgToolTip.ShowAlways = true;
            msgToolTip.SetToolTip(bHistory, "Click Here To See Cost History.");
            msgToolTip.SetToolTip(bOption, "Click Here To Change Option.");
            msgToolTip.SetToolTip(bClose, "Click Here To Close This Window.");
            msgToolTip.SetToolTip(bSubmit, "Click Here To Submit.");
            msgToolTip.SetToolTip(bExit, "Click Here To Exit Application.");
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
                tbQuantity.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithOutDot);
                tbAmount.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithOutDot);
            }
            else
            {
                tbQuantity.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithDot);
                tbAmount.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithDot);

            }
        }

        private void Dot2PFunction(string strValue)
        {
            if (strValue.IndexOf(".") > -1)
            {
                if (strValue.Length - strValue.IndexOf(".") == 3)
                {
                    tbQuantity.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithOutAny);
                }
            }
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            funCost();
        }

        private void funCost()
        {
            string strValue = tbQuantity.Text;
            DotCheckFunction(strValue);
            Dot2PFunction(strValue);

            if (strValue.Equals(".") == false && strValue.Length > 0)
            {
                lQuantity.ForeColor = Color.Black;
                lLt.ForeColor = Color.Black;

                double boxValue = System.Convert.ToDouble(strValue);
                string strItem = cbItem.Text;

                getValue cfdb = new getValue();

                double dbValue = cfdb.getInfo(strItem, "cost");
                double stockValue = cfdb.getInfo(strItem, "stock");

                double priceLitre = 0;

                priceLitre = boxValue * dbValue;

                priceLitre = Math.Round(priceLitre, 4);
                strValue = Convert.ToString(priceLitre);
                tbAmount.Text = strValue;

                lLt.ForeColor = Color.Black;
                lTk.ForeColor = Color.Black;
            }
            else
            {
                tbAmount.Text = "";
            }
        }

        private void tbQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            double boxQuantity = 0.0;
            if (tbQuantity.Text.Equals("") == false && tbQuantity.Text.Equals(".") == false)
            {
                boxQuantity = System.Convert.ToDouble(tbQuantity.Text);
            }

            if (boxQuantity == 0)
            {
                tbQuantity.Text = "";
            }
        }

        private void cbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            funCost();
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

        private void fuSet()
        {
            lOption.ForeColor = Color.Black;
            lQuantity.ForeColor = Color.Black;
            lLt.ForeColor = Color.Black;
            lAmount.ForeColor = Color.Black;
            lTk.ForeColor = Color.Black;

            cbItem.SelectedIndex = 0;
            cbOthers.Text = "";
            tbQuantity.Text = "0";
            tbAmount.Text = "0";
            lOption.Text = "Select Item :";

            cbItem.Visible = true;
            cbOthers.Visible = false;

            lQuantity.Visible = true;
            tbQuantity.Visible = true;
            lLt.Visible = true;
            tbAmount.Enabled = false;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            string strItem = "";
            if (cbItem.Visible == true && cbOthers.Visible == false)
            {
                strItem = cbItem.Text;
            }
            else
            {
                strItem = cbOthers.Text;
            }

            double boxValue = 0.0;

            if (cbItem.Visible == true && cbOthers.Visible == false)
            {
                if (tbQuantity.Text.Equals("") == false && tbQuantity.Text.Equals(".") == false)
                {
                    boxValue = System.Convert.ToDouble(tbQuantity.Text);
                }
            }
            else
            {
                if (tbAmount.Text.Equals("") == false && tbAmount.Text.Equals(".") == false)
                {
                    boxValue = System.Convert.ToDouble(tbAmount.Text);
                }
            }

            if (strItem.Equals("") == false && boxValue != 0.0 )
            {
                SqlConnection con = obj.ConnectSQL();

                try
                {
                    con.Open();
                    SqlCommand select = new SqlCommand();
                    select.Connection = con;
                    SqlDataReader reader;

                    string dates = System.DateTime.Now.ToString("yyyy-MM-dd");
                    string times = System.DateTime.Now.ToLongTimeString();

                    dataCount dc = new dataCount();
                    string chkCost = "";
                    if (cbItem.Visible == true && cbOthers.Visible == false)
                    {
                        chkCost = "costDaily";
                        int intCount = dc.rowCount("costDaily") + 1;
                        select.CommandText = "insert into daillyCost values ('" + intCount + "', N'" + strItem + "','" + tbQuantity.Text + "','" + tbAmount.Text + "','" + dates + "','" + times + "')";
                    }
                    else
                    {
                        chkCost = "costOthers";
                        int intCount = dc.rowCount("costOthers") + 1;
                        select.CommandText = "insert into othersCost values ('" + intCount + "', N'" + strItem + "','" + tbAmount.Text + "','" + dates + "','" + times + "')";
                    }
                    reader = select.ExecuteReader();
                    reader.Close();

                    //fuSet();
                    //this.Hide();
                    FormCostHistory rabin = new FormCostHistory(chkCost);
                    rabin.ShowDialog();
                    //this.Close();

                    this.FormCost_Load(this, null);
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
                if (boxValue == 0.0 && countType % 2 == 0)
                {
                    lQuantity.ForeColor = Color.Red;
                    lLt.ForeColor = Color.Red;
                }

                if (boxValue == 0.0 && countType % 2 != 0)
                {
                    lAmount.ForeColor = Color.Red;
                    lTk.ForeColor = Color.Red;
                }

                if (strItem.Equals("") == true)
                {
                    lOption.ForeColor = Color.Red;
                }

                MessageBox.Show("Please Ensure Required Field ...", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bHistory_Click(object sender, EventArgs e)
        {
            string chkCost = "";
            if (cbItem.Visible == true && cbOthers.Visible == false)
            {
                chkCost = "costDaily";
            }
            else
            {
                chkCost = "costOthers";
            }
           
            //this.Hide();
            FormCostHistory rabin = new FormCostHistory(chkCost);
            rabin.ShowDialog();
            //this.Close();

            //this.FormCost_Load(this, null);
        }

        private void bOption_Click(object sender, EventArgs e)
        {
            countType += 1;
            if (countType % 2 == 0)
            {
                fuSet();
            }
            else
            {
                lOption.ForeColor = Color.Black;
                lQuantity.ForeColor = Color.Black;
                lLt.ForeColor = Color.Black;
                lAmount.ForeColor = Color.Black;
                lTk.ForeColor = Color.Black;

                cbItem.SelectedIndex = 0;
                cbOthers.Text = "";
                tbQuantity.Text = "0";
                tbAmount.Text = "0";
                lOption.Text = "Type Here :";

                cbOthers.Visible = true;
                cbItem.Visible = false;

                lQuantity.Visible = false;
                tbQuantity.Visible = false;
                lLt.Visible = false;
                tbAmount.Enabled = true;
            }
        }

        private void tbAmount_MouseClick(object sender, MouseEventArgs e)
        {
            double chkValue = 0.0;

            if (tbAmount.Text.Equals("") == false && tbAmount.Text.Equals(".") == false)
            {
                chkValue = System.Convert.ToDouble(tbAmount.Text);
            }

            if (chkValue == 0)
            {
                tbAmount.Text = "";
            }
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            if (tbAmount.Text.Length != 0)
            {
                lAmount.ForeColor = Color.Black;
                lTk.ForeColor = Color.Black;
            }
        }

        private void tbOthers_TextChanged(object sender, EventArgs e)
        {
            if (cbOthers.Text.Length != 0)
            {
                lOption.ForeColor = Color.Black;
            }
        }
    }
}
