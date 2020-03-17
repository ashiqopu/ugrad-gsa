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
    public partial class FormReview : Form
    {
        ConnectDB obj = new ConnectDB();

        public FormReview()
        {
            InitializeComponent();
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

        private void Review_Load(object sender, EventArgs e)
        {
            refreshReview();
            ToolTip_Hover();
        }

        private void ToolTip_Hover()
        {
            ToolTip msgToolTip = new ToolTip();
            msgToolTip.ToolTipIcon = ToolTipIcon.Info;
            msgToolTip.IsBalloon = true;
            msgToolTip.ShowAlways = true;
            msgToolTip.SetToolTip(bDelete, "Select & Click Here To Delete.");
            msgToolTip.SetToolTip(bClose, "Click Here To Close This Window.");
            msgToolTip.SetToolTip(bExit, "Click Here To Exit Application.");
        }

        private void refreshReview()
        {
            SqlConnection con = obj.ConnectSQL();

            try
            {
                con.Open();
                SqlCommand select = new SqlCommand();
                select.Connection = con;

                DataTable dataset = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("select * from tempItem", con);
                sda.Fill(dataset);
                dgvReview.DataSource = dataset;
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

        private void bDelete_Click(object sender, EventArgs e)
        {
            int countRow = 0;
            string[] selectedRowArray = new string[39];

            foreach (DataGridViewRow selectedRow in this.dgvReview.SelectedRows)
            {
                selectedRowArray[countRow] = selectedRow.Cells[0].Value.ToString();
                dgvReview.Rows.RemoveAt(selectedRow.Index);

                countRow += 1;
            }

            SqlConnection con = obj.ConnectSQL();

            try
            {
                con.Open();
                SqlCommand select = new SqlCommand();
                select.Connection = con;
                SqlDataReader reader;

                for (int i = 0; i < countRow; i++)
                {
                    int chkDelete = System.Convert.ToInt16(selectedRowArray[i]);

                    double chkAmount = 0;

                    select.CommandText = "select * from tempItem where serial = '" + chkDelete + "'";
                    reader = select.ExecuteReader();
                    if (reader.Read())
                    {
                        chkAmount = System.Convert.ToDouble(reader[3].ToString());
                    }
                    reader.Close();

                    double hitTotal = GV.GlobalTotal;
                    GV.GlobalTotal = hitTotal - chkAmount;

                    select.CommandText = "delete from tempItem where serial = '" + chkDelete + "'";
                    reader = select.ExecuteReader();
                    reader.Close();

                    int hitDelete = GV.GlobalAdd;
                    GV.GlobalAdd = hitDelete - 1;
                }

                {
                    string[] strChk = new string[39];
                    int tempCount = 0;

                    select.CommandText = "select * from tempItem";
                    reader = select.ExecuteReader();
                    while (reader.Read())
                    {
                        strChk[tempCount] = reader[0].ToString();
                        tempCount += 1;
                    }
                    reader.Close();

                    for (int i = 0; i < tempCount; i++)
                    {
                        int intChk = System.Convert.ToInt16(strChk[i]);
                        select.CommandText = "update tempItem set serial = '" + (i + 1) + "' where serial = '" + intChk + "'";
                        reader = select.ExecuteReader();
                        reader.Close();
                    }
                }

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

            refreshReview();
        }
    }
}
