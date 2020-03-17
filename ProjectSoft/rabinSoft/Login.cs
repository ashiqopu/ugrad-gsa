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
    public partial class FormLogin : Form
    {
        ConnectDB obj = new ConnectDB();

        public FormLogin()
        {
            InitializeComponent();
            tbSaler.KeyDown += new KeyEventHandler(tb_KeyDown);
            tbPass.KeyDown += new KeyEventHandler(tb_KeyDown);
        }

        void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitEnter();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbPass.PasswordChar = '*';
            ToolTip_Hover();
        }

        private void ToolTip_Hover()
        {
            ToolTip msgToolTip = new ToolTip();
            msgToolTip.ToolTipIcon = ToolTipIcon.Info;
            msgToolTip.IsBalloon = true;
            msgToolTip.ShowAlways = true;
            msgToolTip.SetToolTip(bSubmit, "Click Here To Login.");
            msgToolTip.SetToolTip(bExit, "Click Here To Exit Application.");
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

        private void bSubmit_Click(object sender, EventArgs e)
        {
            submitEnter();
        }

        void submitEnter()
        {
            string strSaler = tbSaler.Text;
            string strPassword = tbPass.Text;

            if (strSaler.Length == 0 || strPassword.Length == 0)
            {
                LabelName.ForeColor = Color.Red;
                LabelPassword.ForeColor = Color.Red;
                MessageBox.Show("Please Ensure Required Field ...", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = obj.ConnectSQL();

                try
                {
                    con.Open();
                    SqlCommand select = new SqlCommand();
                    select.Connection = con;

                    select.CommandText = "select * from login where username = '" + strSaler + "' and password = '" + strPassword + "'";
                    SqlDataReader reader = select.ExecuteReader();

                    if (reader.Read())
                    {
                        GV.GlobalSaler = strSaler;
                        this.Hide();
                        FormEntry rabin = new FormEntry();
                        rabin.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        tbSaler.ForeColor = Color.Red;
                        tbPass.ForeColor = Color.Red;
                        MessageBox.Show("Invalid ID : Please Try Again ...", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
