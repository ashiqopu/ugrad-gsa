using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

class ConnectDB
{
    public SqlConnection ConnectSQL()
    {
        SqlConnection con =
            new SqlConnection(@"Data Source=XOR-LT\SQLEXPRESS;"
                + "Initial Catalog=project;"
                + "Persist Security Info=True;"
                + "User ID=project;Password=asp.net");

        return con;
    }
}
