using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace rabinSoft
{
    class dataCount
    {
        public int rowCount(string strStatus)
        {
            int count = 0;

            ConnectDB obj = new ConnectDB();
            SqlConnection con = obj.ConnectSQL();

            try
            {
                string stmt = "";
                if (strStatus.Equals("usage")==true)
                    stmt = "SELECT COUNT(*) FROM dbo.usage";
                else if (strStatus.Equals("tempItem") == true)
                    stmt = "SELECT COUNT(*) FROM dbo.tempItem";
                else if (strStatus.Equals("stockLoad") == true)
                    stmt = "SELECT COUNT(*) FROM dbo.stockLoad";
                else if (strStatus.Equals("duePay") == true)
                    stmt = "SELECT COUNT(*) FROM dbo.duePay";
                else if (strStatus.Equals("costDaily") == true)
                    stmt = "SELECT COUNT(*) FROM dbo.daillyCost";
                else if (strStatus.Equals("costOthers") == true)
                    stmt = "SELECT COUNT(*) FROM dbo.othersCost";

                using (con)
                using (SqlCommand cmdCount = new SqlCommand(stmt, con))
                {
                    con.Close(); con.Open();
                    count = (int)cmdCount.ExecuteScalar();
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

            return count;
        }
    }
}
