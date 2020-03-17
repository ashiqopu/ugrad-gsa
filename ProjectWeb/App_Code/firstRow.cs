using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for firstRow
/// </summary>
public class firstRow
{
    public string rfirstRow(string strTable)
	{
        ConnectDB obj = new ConnectDB();

        string stmt = "";
        string strReturn = "";

        SqlConnection con = obj.ConnectSQL();

        try
        {
            if (strTable.Equals("details") == true)
                stmt = "SELECT TOP 1 Items FROM dbo.details";
            else if (strTable.Equals("salesperson") == true)
                stmt = "SELECT TOP 1 Username FROM dbo.login where type = 'salesperson'";

            using (con)
            using (SqlCommand cmdCount = new SqlCommand(stmt, con))
            {
                con.Open();
                strReturn = (string)cmdCount.ExecuteScalar();
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

        return strReturn;
	}
}