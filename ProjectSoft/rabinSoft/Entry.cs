using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace rabinSoft
{
    public partial class FormEntry : Form
    {
        ConnectDB obj = new ConnectDB();

        int countDotQA = 0;
        int countDotPD = 0;

        Boolean checkQuantity = true;
        Boolean checkAmount = true;

        Boolean checkPayment = true;
        Boolean checkDue = true;

        string rSaler = "rabin"; // by default

        FormDisplay opu = new FormDisplay();

        public FormEntry()
        {
            InitializeComponent();

            this.Location = new Point(5,5);

            Timer.Start();
            rSaler = GV.GlobalSaler;

            tbCustomer.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_Name);
            tbPlate.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_Name);

            tbQuantity.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithDot);
            tbAmount.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithDot);

            tbPay.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithDot);
            tbDue.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithDot);

            tbQuantity.KeyDown += new KeyEventHandler(tb_KeyDown);
            tbAmount.KeyDown += new KeyEventHandler(tb_KeyDown);
        }

        void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitEnter();
            }
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

        private void FormEntry_Load(object sender, EventArgs e)
        {
            this.detailsTableAdapter.Fill(this.entryItemsDataSet.details);
            
            tbSalesman.Text = rSaler;

            string Today = DateTime.Now.ToString("dd-MM-yyyy");

            tbCustomer.TextAlign = HorizontalAlignment.Center;
            tbPlate.TextAlign = HorizontalAlignment.Center;
            tbSalesman.TextAlign = HorizontalAlignment.Center;

            tbQuantity.TextAlign = HorizontalAlignment.Center;
            tbAmount.TextAlign = HorizontalAlignment.Center;

            tbTotal.TextAlign = HorizontalAlignment.Center;
            tbPay.TextAlign = HorizontalAlignment.Center;
            tbDue.TextAlign = HorizontalAlignment.Center;

            resetRefresh();
            ToolTip_Hover();

            if (GV.GlobalDisplay == false)
            {
                opu.Show();
                int x = SystemInformation.VirtualScreen.Width;
                int y = opu.Width + 5;
                opu.Location = new Point(x - y, 5);

                GV.GlobalDisplay = true;
            }
        }

        private void ToolTip_Hover()
        {
            ToolTip msgToolTip = new ToolTip();
            msgToolTip.ToolTipIcon = ToolTipIcon.Info;
            msgToolTip.IsBalloon = true;
            msgToolTip.ShowAlways = true;
            msgToolTip.SetToolTip(bStock, "Click Here To See Stock Status.");
            msgToolTip.SetToolTip(bCost, "Click Here To See Cost Status.");
            msgToolTip.SetToolTip(bDue, "Click Here To See Due Status.");
            msgToolTip.SetToolTip(bAdd, "Click Here To Add Item(s).");
            msgToolTip.SetToolTip(bReview, "Click Here To Review Item(s).");
            msgToolTip.SetToolTip(bSubmit, "Click Here To Submit.");
            msgToolTip.SetToolTip(bReset, "Click Here To Reset This Window.");
            msgToolTip.SetToolTip(bExit, "Click Here To Exit Application.");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lTime.Text = dateTime.ToString();

            this.lcountItem.Text = GV.GlobalAdd.ToString() + " Item(s) Added";
            this.tbTotal.Text = GV.GlobalTotal.ToString();

            if(GV.GlobalAdd > 0)
            {
                lcountItem.ForeColor = Color.Green;
            }
            else
            {
                lcountItem.ForeColor = Color.Red;
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            resetRefresh();
            GV.GlobalTk = 0.0;
            GV.GlobalLt = 0.0;
            opu.DisplayEntry();
        }

        private void resetRefresh()
        {
            lCn.ForeColor = Color.Black;
            lPn.ForeColor = Color.Black;
            lLt.ForeColor = Color.Black;
            lTk.ForeColor = Color.Black;
            lCustomer.ForeColor = Color.Black;
            lPlate.ForeColor = Color.Black;
            lItems.ForeColor = Color.Black;
            lDue.ForeColor = Color.Black;
            bDue.ForeColor = Color.Black;

            CheckBoxQuantity.Checked = true;
            cbPayment.Checked = true;

            cbItem.SelectedIndex = 0;
            tbQuantity.Text = "0";
            tbAmount.Text = "0";

            tbTotal.Text = "0";
            tbPay.Text = "0";
            tbDue.Text = "0";

            tbCustomer.Text = "";
            tbPlate.Text = "";

            lcountItem.ForeColor = Color.Black;
            lcountItem.Text = "0 Item(s) Added";
            GV.GlobalAdd = 0;
            GV.GlobalTotal = 0;

            deleteTempItem dti = new deleteTempItem();
            dti.rowDelete();
        }

        private void bReview_Click(object sender, EventArgs e)
        {
            itemUsageList("review");
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            itemUsageList("submit");
        }

        private void itemUsageList(string strChk)
        {
            dataCount dcTemp = new dataCount();
            int tempCount = dcTemp.rowCount("tempItem");

            if (tempCount > 0)
            {
                string strCustomer = tbCustomer.Text;
                string strPlate = tbPlate.Text;
                string strSalesman = tbSalesman.Text;

                string strTotal = tbTotal.Text;
                string strPay = tbPay.Text;
                string strDue = tbDue.Text;

                strTotal = getString(strTotal);
                strPay = getString(strPay);
                strDue = getString(strDue);

                cbItem.SelectedIndex = 0;
                tbQuantity.Text = "0";
                tbAmount.Text = "0";

                if (strChk.Equals("submit") == true)
                {
                    double chkPay = 0.0;
                    double chkDue = 0.0;

                    if (tbPay.Text.Equals(".") == false && tbPay.Text.Length != 0)
                    {
                        chkPay = System.Convert.ToDouble(tbPay.Text);
                    }

                    if (tbDue.Text.Equals(".") == false && tbDue.Text.Length != 0)
                    {
                        chkDue = System.Convert.ToDouble(tbDue.Text);
                    }

                    if (chkPay > 0 || chkDue > 0)
                    {
                        FormConfirm rabin = new FormConfirm(tempCount, tbCustomer.Text, tbPlate.Text, tbSalesman.Text, tbTotal.Text, tbPay.Text, tbDue.Text);
                        rabin.ShowDialog();

                        this.FormEntry_Load(this, null);
                    }
                    else
                    {
                        MessageBox.Show("Required Pay/Due Field...", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (strChk.Equals("review") == true)
                {
                    FormReview rabin = new FormReview();
                    rabin.ShowDialog();             
                }
            }
            else
            {
                lcountItem.ForeColor = Color.Red;
                MessageBox.Show("No Item Added...", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void bStock_Click(object sender, EventArgs e)
        {
            FormStock rabin = new FormStock();
            rabin.ShowDialog();
        }

        private void CheckBoxQuantity_CheckedChanged(object sender, EventArgs e)
        {
            string strValue = tbQuantity.Text;
            if (strValue.Equals("") == true || strValue.Equals(".") == true)
            {
                tbAmount.Text = "";
                countDotQA = 0;
            }

            if (CheckBoxQuantity.Checked == true)
            {
                tbQuantity.ReadOnly = false;
                tbAmount.ReadOnly = true;

                checkQuantity = true;
                checkAmount = false;

                CheckBoxAmount.Checked = false;

                string strQuantity = tbQuantity.Text;
                DotCheckFunctionAQ(strQuantity);
                Dot2PFunctionAQ(strQuantity);

            }
            else
            {
                tbQuantity.ReadOnly = true;
                tbAmount.ReadOnly = false;

                checkQuantity = false;
                checkAmount = true;

                CheckBoxAmount.Checked = true;

                string strAmount = tbAmount.Text;
                DotCheckFunctionAQ(strAmount);
                Dot2PFunctionAQ(strAmount);
            }
        }

        private void CheckBoxAmount_CheckedChanged(object sender, EventArgs e)
        {
            string strValue = tbAmount.Text;
            if (strValue.Equals("") == true || strValue.Equals(".") == true)
            {
                tbQuantity.Text = "";
                countDotQA = 0;
            }

            if (CheckBoxAmount.Checked == true)
            {
                tbQuantity.ReadOnly = true;
                tbAmount.ReadOnly = false;

                checkQuantity = false;
                checkAmount = true;

                CheckBoxQuantity.Checked = false;

                string strAmount = tbAmount.Text;
                DotCheckFunctionAQ(strAmount);
                Dot2PFunctionAQ(strAmount);

            }
            else
            {
                tbQuantity.ReadOnly = false;
                tbAmount.ReadOnly = true;

                checkQuantity = true;
                checkAmount = false;

                CheckBoxQuantity.Checked = true;

                string strQuantity = tbQuantity.Text;
                DotCheckFunctionAQ(strQuantity);
                Dot2PFunctionAQ(strQuantity);

            }
        }

        public void DotCheckFunctionAQ(string strDot)
        {
            if (strDot.IndexOf(".") < 0)
            {
                countDotQA = 0;
            }

            for (int i = 0; i < strDot.Length; i++)
            {
                if (strDot[i] == '.')
                {
                    countDotQA = 1;
                    break;
                }
            }

            if (countDotQA ==1 )
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

        public void DotCheckFunctionPD(string strDot)
        {
            if (strDot.IndexOf(".") < 0)
            {
                countDotPD = 0;
            }

            for (int i = 0; i < strDot.Length; i++)
            {
                if (strDot[i] == '.')
                {
                    countDotPD = 1;
                    break;
                }
            }

            if (countDotPD == 1)
            {
                tbPay.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithOutDot);
                tbDue.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithOutDot);
            }
            else
            {
                tbPay.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithDot);
                tbDue.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithDot);
            }
        }

        private void Dot2PFunctionAQ(string strValue)
        {
            if (strValue.IndexOf(".") > -1)
            {
                if (strValue.Length - strValue.IndexOf(".") == 3)
                {
                    if (checkAmount == true && checkQuantity==false)
                    {
                        tbAmount.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithOutAny);
                    }
                    else
                    {
                        tbQuantity.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithOutAny);
                    }
                }
            }
        }    

        private void Dot2PFunctionPD(string strValue)
        {
            if (strValue.IndexOf(".") > -1)
            {
                if (strValue.Length - strValue.IndexOf(".") == 3)
                {
                    if (checkPayment == true && checkDue == false)
                    {
                        tbPay.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithOutAny);
                    }
                    else
                    {
                        tbDue.KeyPress += new KeyPressEventHandler(validTextBox_KeyPress_WithOutAny);
                    }
                }
            }
        }

        private void cbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            getValue cfdb = new getValue();
            double dbValue = cfdb.getInfo(cbItem.Text, "price");

            GV.GlobalItem = cbItem.Text;
            GV.GlobalUnit = dbValue;
            GV.GlobalStock = cfdb.getInfo(cbItem.Text, "stock");
            string TkLt = "";
            if (CheckBoxQuantity.Checked == true) { TkLt = "Lt"; }
            else { TkLt = "Tk"; }
            GV.GlobalType = TkLt;

            string strValue = "";

            if (checkQuantity == true && checkAmount == false)
            {
                strValue = tbQuantity.Text;
            }
            else
            {
                strValue = tbAmount.Text;
            }

            if (strValue.Equals(".") == false && strValue.Length > 0)
            {
                double boxValue = System.Convert.ToDouble(strValue);

                double priceLitre = 0;

                if (checkQuantity == true && checkAmount == false)
                {
                    priceLitre = boxValue * dbValue;

                    GV.GlobalTk = priceLitre;
                    GV.GlobalLt = boxValue;
                }
                else
                {
                    priceLitre = boxValue / dbValue;

                    GV.GlobalLt = priceLitre;
                    GV.GlobalTk = boxValue;
                }

                priceLitre = Math.Round(priceLitre, 4);
                strValue = Convert.ToString(priceLitre);

                if (checkQuantity == true && checkAmount == false)
                {
                    tbAmount.Text = strValue;
                }
                else
                {
                    tbQuantity.Text = strValue;
                }

                opu.DisplayEntry();
            }
            else
            {
                GV.GlobalTk = 0.0;
                GV.GlobalLt = 0.0;

                opu.DisplayEntry();
            }
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            if (checkQuantity == true)
            {
                string strValue = tbQuantity.Text;
                DotCheckFunctionAQ(strValue);
                Dot2PFunctionAQ(strValue);

                getValue cfdb = new getValue();
                double dbValue = cfdb.getInfo(cbItem.Text, "price");

                GV.GlobalItem = cbItem.Text;
                GV.GlobalUnit = dbValue;
                GV.GlobalStock = cfdb.getInfo(cbItem.Text, "stock");
                string TkLt = "";
                if (CheckBoxQuantity.Checked == true) { TkLt = "Lt"; }
                else { TkLt = "Tk"; }
                GV.GlobalType = TkLt;

                if (strValue.Equals(".") == false && strValue.Length > 0)
                {
                    double boxValue = double.Parse(strValue, CultureInfo.InvariantCulture);

                    double priceLitre = 0;
                    priceLitre = boxValue * dbValue;

                    priceLitre = Math.Round(priceLitre, 4);
                    strValue = Convert.ToString(priceLitre);
                    tbAmount.Text = strValue;

                    lLt.ForeColor = Color.Black;
                    lTk.ForeColor = Color.Black;

                    GV.GlobalTk = priceLitre;
                    GV.GlobalLt = boxValue;

                    chkStock();
                    opu.DisplayEntry();
                }
                else
                {
                    GV.GlobalLt = 0.0;
                    GV.GlobalTk = 0.0;

                    opu.DisplayEntry();
                    tbAmount.Text = "";
                }
            }
        }

        private void chkStock()
        {
            getValue gv = new getValue();

            double dbQuantity = gv.getInfo(cbItem.Text, "stock");
            double boxQuantity = System.Convert.ToDouble(tbQuantity.Text);

            double insertQuantity = dbQuantity - boxQuantity;

            if (insertQuantity < 0)
            {
                tbQuantity.Text = "0";
                tbAmount.Text = "0";
                GV.GlobalLt = 0.0;
                GV.GlobalTk = 0.0;
                MessageBox.Show("Limit Exceeded : Please Check Stock & Upload Resources ...", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            if (checkAmount == true)
            {
                string strValue = tbAmount.Text;
                DotCheckFunctionAQ(strValue);
                Dot2PFunctionAQ(strValue);

                getValue cfdb = new getValue();
                double dbValue = cfdb.getInfo(cbItem.Text, "price");

                GV.GlobalItem = cbItem.Text;
                GV.GlobalUnit = dbValue;
                GV.GlobalStock = cfdb.getInfo(cbItem.Text, "stock");
                string TkLt = "";
                if (CheckBoxQuantity.Checked == true) { TkLt = "Lt"; }
                else { TkLt = "Tk"; }
                GV.GlobalType = TkLt;

                if (strValue.Equals(".") == false && strValue.Length > 0)
                {
                    double boxValue = double.Parse(strValue, CultureInfo.InvariantCulture);

                    double priceLitre = 0;

                    priceLitre = boxValue / dbValue;

                    priceLitre = Math.Round(priceLitre, 4);
                    strValue = Convert.ToString(priceLitre);
                    tbQuantity.Text = strValue;

                    lLt.ForeColor = Color.Black;
                    lTk.ForeColor = Color.Black;

                    GV.GlobalLt = priceLitre;
                    GV.GlobalTk = boxValue;

                    chkStock();
                    opu.DisplayEntry();
                }
                else
                {
                    GV.GlobalLt = 0.0;
                    GV.GlobalTk = 0.0;

                    opu.DisplayEntry();

                    tbQuantity.Text = "";
                }
            }
        }

        private void tbAmount_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkAmount == true && checkQuantity == false)
            {
                string strAmount = tbAmount.Text;

                if (strAmount.Equals(".") == false && strAmount.Equals("") == false)
                {
                    double valAmount = double.Parse(strAmount, CultureInfo.InvariantCulture);
                    if (valAmount == 0.0)
                    {
                        tbAmount.Text = "";
                    }
                }
            }           
        }      

        private void tbQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkQuantity == true && checkAmount == false)
            {
                string strQuantity = tbQuantity.Text;

                if (strQuantity.Equals(".") == false && strQuantity.Equals("") == false)
                {
                    double valQuantity = double.Parse(strQuantity, CultureInfo.InvariantCulture);
                    if (valQuantity == 0.0)
                    {
                        tbQuantity.Text = "";
                    }
                }
            }
        }

        private void cbPayment_CheckedChanged(object sender, EventArgs e)
        {
            string strValue = tbPay.Text;

            if (cbPayment.Checked == true)
            {
                if (strValue.Equals("") == true || strValue.Equals(".") == true)
                {
                    tbDue.Text = "";
                    countDotPD = 0;
                }

                tbPay.ReadOnly = false;
                tbDue.ReadOnly = true;

                cbDue.Checked = false;

                checkPayment = true;
                checkDue = false;
            }
            else
            {
                if (strValue.Equals("") == true || strValue.Equals(".") == true)
                {
                    tbPay.Text = "";
                    countDotPD = 0;
                }

                tbPay.ReadOnly = true;
                tbDue.ReadOnly = false;

                cbDue.Checked = true;

                checkPayment = false;
                checkDue = true;
            }

        }

        private void cbDue_CheckedChanged(object sender, EventArgs e)
        {
            string strValue = tbDue.Text;
            
            if (cbDue.Checked == true)
            {
                if (strValue.Equals("") == true || strValue.Equals(".") == true)
                {
                    tbPay.Text = "";
                    countDotPD = 0;
                }

                tbPay.ReadOnly = true;
                tbDue.ReadOnly = false;

                cbPayment.Checked = false;

                checkPayment = false;
                checkDue = true;
            }
            else
            {
                if (strValue.Equals("") == true || strValue.Equals(".") == true)
                {
                    tbDue.Text = "";
                    countDotPD = 0;
                }

                tbPay.ReadOnly = false;
                tbDue.ReadOnly = true;

                cbPayment.Checked = true;

                checkPayment = true;
                checkDue = false;
            }
        }

        private void tbPayment_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkPayment == true && checkDue == false)
            {
                string strAmount = tbPay.Text;

                if (strAmount.Equals(".") == false && strAmount.Equals("") == false)
                {
                    double valAmount = double.Parse(strAmount, CultureInfo.InvariantCulture);
                    if (valAmount == 0.0)
                    {
                        tbPay.Text = "";
                    }
                }
            }
        }

        private void tbDue_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkPayment == false && checkDue == true)
            {
                string strAmount = tbDue.Text;

                if (strAmount.Equals(".") == false && strAmount.Equals("") == false)
                {
                    double valAmount = double.Parse(strAmount, CultureInfo.InvariantCulture);
                    if (valAmount == 0.0)
                    {
                        tbDue.Text = "";
                    }
                }
            }
        }

        private void tbPayment_TextChanged(object sender, EventArgs e)
        {
            if (checkPayment == true)
            {
                string strPayment = tbPay.Text;
                DotCheckFunctionPD(strPayment);
                Dot2PFunctionPD(strPayment);

                double valAmount = getAmount();

                if (strPayment.Equals(".") == false && strPayment.Equals("") == false)
                {
                    double valPayment = 0.0;
                    valPayment = double.Parse(strPayment, CultureInfo.InvariantCulture);

                    if (valPayment <= valAmount)
                    {
                        double valDue = valAmount - valPayment;
                        valDue = Math.Round(valDue, 4);
                        string strDue = System.Convert.ToString(valDue);
                        tbDue.Text = strDue;
                    }
                    else
                    {
                        MessageBox.Show("Amount exceeded ...", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbPay.Text = "0";
                    }
                }
                else
                {
                    string strDue = System.Convert.ToString(valAmount);
                    tbDue.Text = strDue;
                }
            }
        }

        private void tbDue_TextChanged(object sender, EventArgs e)
        {
            if (checkDue == true)
            {
                string strDue = tbDue.Text;
                DotCheckFunctionPD(strDue);
                Dot2PFunctionPD(strDue);

                double valAmount = getAmount();

                if (strDue.Equals(".") == false && strDue.Equals("") == false)
                {
                    double valDue = 0.0;            
                    valDue = double.Parse(strDue, CultureInfo.InvariantCulture);
                    if(valDue <= valAmount)
                    {
                        double valPayment = valAmount - valDue;
                        valPayment = Math.Round(valPayment, 4);
                        string strPayment = System.Convert.ToString(valPayment);
                        tbPay.Text = strPayment;
                    }
                    else
                    {
                        MessageBox.Show("Amount exceeded ...", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbDue.Text = "0";
                    }
                }
                else
                {
                    string strPayment = System.Convert.ToString(valAmount);
                    tbPay.Text = strPayment;
                }
            }
        }

        public double getAmount()
        {
            dataCount dcTemp = new dataCount();
            int tempCount = dcTemp.rowCount("tempItem");

            double dbTotal = 0.0;

            if (tempCount > 0)
            {
                SqlConnection con = obj.ConnectSQL();

                try
                {
                    con.Open();
                    SqlCommand select = new SqlCommand();
                    select.Connection = con;

                    select.CommandText = "select * from tempItem";
                    SqlDataReader reader = select.ExecuteReader();
                    while (reader.Read())
                    {
                        dbTotal = dbTotal + System.Convert.ToDouble(reader[3].ToString());
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
            }

            return dbTotal;
        }

        public void duePayment()
        {
            double valAmount = getAmount();
            tbTotal.Text = System.Convert.ToString(valAmount);

            if (cbPayment.Checked == true && cbDue.Checked == false)
            {
                double valPay = 0.0;
                if (tbPay.Text.Equals("") == false && tbPay.Text.Equals(".") == false)
                    valPay = System.Convert.ToDouble(tbPay.Text);
                double valDue = valAmount - valPay;
                tbDue.Text = System.Convert.ToString(valDue);
            }
            else
            {
                double valDue = 0.0;
                if (tbDue.Text.Equals("") == false && tbDue.Text.Equals(".") == false)
                    valDue = System.Convert.ToDouble(tbDue.Text);
                double valPay = valAmount - valDue;
                tbPay.Text = System.Convert.ToString(valPay);
            }
        }

        public string getString(string str)
        {
            double chkTry = 0.0;

            if (str.Equals("") == false && str.Equals(".") == false)
            {
                chkTry = System.Convert.ToDouble(str);
            }

            str = chkTry.ToString();
            return str;
        }

        private void bDue_Click(object sender, EventArgs e)
        {
            string strCustomer = tbCustomer.Text;
            string strPlate = tbPlate.Text;

            FormDue rabin = new FormDue(strCustomer, strPlate);
            rabin.ShowDialog();
        }

        private void tbCustomer_TextChanged(object sender, EventArgs e)
        {

            string strCustomer = tbCustomer.Text;
            string strPlate = tbPlate.Text;

            if (tbCustomer.Text.Equals("") == false)
            {
                lCustomer.ForeColor = Color.Black;
            }
            else
            {
                //lCustomer.ForeColor = Color.Red;
            }

            chkDue(strCustomer, strPlate);
        }

        private void tbPlate_TextChanged(object sender, EventArgs e)
        {
            string strCustomer = tbCustomer.Text;
            string strPlate = tbPlate.Text;

            if (strPlate.Equals("") == false)
            {
                lPlate.ForeColor = Color.Black;
            }
            else
            {
                //lPlate.ForeColor = Color.Red;
            }

            chkDue(strCustomer, strPlate);
        }

        private void chkDue(string strCustomer,string strPlate)
        {
            int dueCheck = 0;

            if (strCustomer.Length == 0 && strPlate.Length == 0)
            {
                lDue.ForeColor = Color.Black;
                bDue.ForeColor = Color.Black;
            }
            else
            {
                SqlConnection con = obj.ConnectSQL();

                try
                {
                    con.Open();
                    SqlCommand select = new SqlCommand();
                    select.Connection = con;

                    if (strCustomer.Length == 0 && strPlate.Length != 0)
                        select.CommandText = "select * from usage where due != '0' and plate=N'" + strPlate + "'";
                    else if (strCustomer.Length != 0 && strPlate.Length == 0)
                        select.CommandText = "select * from usage where due != '0' and customer=N'" + strCustomer + "'";
                    else if (strCustomer.Length != 0 && strPlate.Length != 0)
                        select.CommandText = "select * from usage where due != '0' and plate=N'" + strPlate + "' and customer=N'" + strCustomer + "'";

                    SqlDataReader reader = select.ExecuteReader();

                    if (reader.Read())
                    {
                        dueCheck++;
                    }

                    if (dueCheck == 0)
                    {
                        lDue.ForeColor = Color.Black;
                        bDue.ForeColor = Color.Black;
                    }
                    else
                    {
                        lDue.ForeColor = Color.Red;
                        bDue.ForeColor = Color.Red;
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
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            submitEnter();
        }

        private void submitEnter()
        {
            double chkQuantity = 0.0;
            double chkAmount = 0.0;

            if (tbQuantity.Text.Equals("") == false && tbQuantity.Text.Equals(".") == false)
                chkQuantity = System.Convert.ToDouble(tbQuantity.Text);

            if (tbAmount.Text.Equals("") == false && tbAmount.Text.Equals(".") == false)
                chkAmount = System.Convert.ToDouble(tbAmount.Text);


            if (tbCustomer.Text.Equals("") == false && tbPlate.Text.Equals("") == false && chkQuantity != 0 && chkAmount != 0)
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

                    select.CommandText = "insert into tempItem values ('" + tempCount + "', N'" + cbItem.Text + "', '" + chkQuantity + "', '" + chkAmount + "')";
                    reader = select.ExecuteReader();
                    reader.Close();

                    int hitAdd = GV.GlobalAdd;
                    GV.GlobalAdd = hitAdd + 1;

                    double hitTotal = GV.GlobalTotal;
                    GV.GlobalTotal = hitTotal + chkAmount;
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

                cbItem.SelectedIndex = 0;
                tbQuantity.Text = "0";
                tbAmount.Text = "0";
            }
            else
            {
                if (tbCustomer.Text.Length == 0)
                {
                    lCustomer.ForeColor = Color.Red;
                }

                if (tbPlate.Text.Length == 0)
                {
                    lPlate.ForeColor = Color.Red;
                }

                if (chkQuantity == 0)
                {
                    lLt.ForeColor = Color.Red;
                }

                if (chkAmount == 0)
                {
                    lTk.ForeColor = Color.Red;
                }

                MessageBox.Show("Ensure Necessary Field(s) ...", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bCost_Click(object sender, EventArgs e)
        {
            FormCost rabin = new FormCost();
            rabin.ShowDialog();
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            double chkPay = 0.0;
            double chkDue = 0.0;

            if(tbPay.Text.Length != 0 && tbPay.Text.Equals(".")==false)
            {
                chkPay = System.Convert.ToDouble(tbPay.Text);
            }

            if(tbDue.Text.Length != 0 && tbDue.Text.Equals(".")==false)
            {
                chkDue = System.Convert.ToDouble(tbDue.Text);
            }

            if (tbTotal.Text.Length != 0 && chkPay != 0 && chkDue != 0)
            {
                double total = System.Convert.ToDouble(tbTotal.Text);
                if (cbPayment.Checked == true && cbDue.Checked == false)
                {
                    double pay = System.Convert.ToDouble(tbPay.Text);
                    double due = total - pay;
                    tbDue.Text = due.ToString();
                }
                else
                {
                    double due = System.Convert.ToDouble(tbDue.Text);
                    double pay = total - due;
                    tbPay.Text = pay.ToString();
                }
            }
            else
            {
                if (cbPayment.Checked == true && cbDue.Checked == false)
                {
                    tbDue.Text = tbTotal.Text;
                }
                else
                {
                    tbPay.Text = tbTotal.Text;
                }
            }
        }

    }
}
