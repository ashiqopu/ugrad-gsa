using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace rabinSoft
{
    class ConnectDB
    {
        public SqlConnection ConnectSQL()
        {
            SqlConnection con =
                new SqlConnection(@"SERVER=project3200.mssql.somee.com;"
                    + "Data Source=project3200.mssql.somee.com;"
                    + "Initial Catalog=project3200;"
                    + "persist security info=False;"
                    + "user id=Project3200_SQLLogin_1;Password=aspdotnet32");
            return con;
        }
    }
}
