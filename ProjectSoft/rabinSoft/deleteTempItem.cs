using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace rabinSoft
{
    class deleteTempItem
    {
        public void rowDelete()
        {
            ConnectDB obj = new ConnectDB();
            SqlConnection con = obj.ConnectSQL();

            try
            {
                con.Open();
                SqlCommand select = new SqlCommand();
                select.Connection = con;
                SqlDataReader reader;

                select.CommandText = "delete from tempItem";
                reader = select.ExecuteReader();
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
