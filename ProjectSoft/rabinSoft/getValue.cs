using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace rabinSoft
{
    class getValue
    {
        public double getInfo(string item, string name)
        {
            ConnectDB obj = new ConnectDB();
            SqlConnection con = obj.ConnectSQL();

            double dbItem = 0.0;

            try
            {
                con.Open();
                SqlCommand select = new SqlCommand();
                select.Connection = con;

                select.CommandText = "select * from details where Items = N'" + item + "'";

                SqlDataReader reader = select.ExecuteReader();

                string strItem = "0";

                if (reader.Read())
                {
                    if(name == "price")
                        strItem = reader[2].ToString();

                    else if (name == "stock")
                        strItem = reader[3].ToString();

                    else if (name == "cost")
                        strItem = reader[1].ToString();
                }

                dbItem = System.Convert.ToDouble(strItem);

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

            return dbItem;
        }
    }
}
