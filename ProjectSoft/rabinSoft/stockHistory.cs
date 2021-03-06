﻿using System;
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
    public partial class FormStockHistory : Form
    {
        ConnectDB obj = new ConnectDB();

        public FormStockHistory()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
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

                string strQuery = "select * from stockLoad order by serial DESC";

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
                int intCount = dc.rowCount("stockLoad");
                if (intCount > 0)
                {
                    SqlConnection con = obj.ConnectSQL();

                    try
                    {
                        con.Open();
                        SqlCommand select = new SqlCommand();
                        select.Connection = con;

                        string dbItem = "0";
                        string dbQuantityU = "0";
                        string dbQuantityS = "0";

                        select.CommandText = "select * from stockLoad where serial='" + intCount + "'";
                        SqlDataReader reader = select.ExecuteReader();

                        if (reader.Read())
                        {
                            dbItem = reader[1].ToString();
                            dbQuantityU = reader[2].ToString();
                            reader.Close();

                            select.CommandText = "select * from details where items = N'" + dbItem + "'";
                            reader = select.ExecuteReader();
                            if (reader.Read())
                            {
                                dbQuantityS = reader[3].ToString();
                            }
                            reader.Close();

                            double totalValue = System.Convert.ToDouble(dbQuantityS) - System.Convert.ToDouble(dbQuantityU);

                            select.CommandText = "update details set stock = '" + totalValue + "' where items = N'" + dbItem + "'";

                            select.ExecuteNonQuery();
                        }

                        select.CommandText = "delete from stockLoad where serial ='" + intCount + "'";
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

        private void bClose_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FormStock rabin = new FormStock();
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
    }
}
