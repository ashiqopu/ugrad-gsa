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
    public partial class FormCostHistory : Form
    {
        ConnectDB obj = new ConnectDB();

        string chkCost = "";
        public FormCostHistory(string str)
        {
            InitializeComponent();
            chkCost = str;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FormCost rabin = new FormCost();
            //rabin.ShowDialog();
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

        private void costHistory_Load(object sender, EventArgs e)
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

                string strQuery = "";
                if (chkCost.Equals("costDaily") == true)
                {
                    strQuery = "select * from daillyCost order by serial DESC";
                }
                else if (chkCost.Equals("costOthers") == true)
                {
                    strQuery = "select * from othersCost order by serial DESC";
                }

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

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to cancel your last update ?", "Cancel : ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataCount dc = new dataCount();
                int intCount = 0;

                if (chkCost.Equals("costDaily") == true)
                {
                    intCount = dc.rowCount("costDaily");
                }
                else if (chkCost.Equals("costOthers") == true)
                {
                    intCount = dc.rowCount("costOthers");
                }

                if (intCount > 0)
                {
                    SqlConnection con = obj.ConnectSQL();

                    try
                    {
                        con.Open();
                        SqlCommand select = new SqlCommand();
                        select.Connection = con;
                        if (chkCost.Equals("costDaily") == true)
                        {
                            select.CommandText = "delete from daillyCost where serial ='" + intCount + "'";
                        }
                        else if (chkCost.Equals("costOthers") == true)
                        {
                            select.CommandText = "delete from othersCost where serial ='" + intCount + "'";
                        }
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
    }
}
