using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for dataCount
/// </summary>
public class dataCount
{
    public int rowCount(string strTable)
    {
        ConnectDB obj = new ConnectDB();

        string stmt="";
        int count = 0;

        SqlConnection con = obj.ConnectSQL();

        try
        {
            if (strTable.Equals("stockLoad")==true)
            stmt = "SELECT COUNT(*) FROM dbo.stockLoad";

            else if (strTable.Equals("details") == true)
                stmt = "SELECT COUNT(*) FROM dbo.details";

            else if (strTable.Equals("salesman") == true)
                stmt = "SELECT COUNT(*) FROM dbo.login where type = 'salesman'";

            using (con)
            using (SqlCommand cmdCount = new SqlCommand(stmt, con))
            {
                con.Open();
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