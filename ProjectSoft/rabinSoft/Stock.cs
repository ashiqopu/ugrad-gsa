using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace rabinSoft
{
    public partial class FormStock : Form
    {
        ConnectDB obj = new ConnectDB();

        int countDot = 0;

        public FormStock()
        {
            InitializeComponent();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            this.detailsTableAdapter.Fill(this.itemsDataSet.details);
            cngStock();
            ToolTip_Hover();
        }

        private void ToolTip_Hover()
        {
            ToolTip msgToolTip = new ToolTip();
            msgToolTip.ToolTipIcon = ToolTipIcon.Info;
            msgToolTip.IsBalloon = true;
            msgToolTip.ShowAlways = true;
            msgToolTip.SetToolTip(bClose, "Click Here To Close This Window.");
            msgToolTip.SetToolTip(bReset, "Click Here To Reset.");
            msgToolTip.SetToolTip(bExit, "Click Here To Exit Application.");
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
            this.Close();
        }

        private void cbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            cngStock();
        }

        private void cngStock()
        {          
            string strItem = cbStock.Text;

            getValue cfdb = new getValue();

            double dbValue = cfdb.getInfo(strItem, "stock");

            ToolTip msgToolTip = new ToolTip();

            msgToolTip.ToolTipIcon = ToolTipIcon.Info;
            msgToolTip.IsBalloon = true;
            msgToolTip.ShowAlways = true;

            msgToolTip.SetToolTip(lLt, "Available " + " '" + dbValue + "' " + " Lt.");
            LAmount.Text = dbValue.ToString();
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            cbStock.SelectedIndex = 0;
        }

        private void bHistory_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormStockHistory rabin = new FormStockHistory();
            rabin.ShowDialog();
            //this.Close();

            this.FormStock_Load(this, null);
        }    
    }
}
