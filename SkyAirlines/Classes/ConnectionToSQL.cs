using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyAirlines
{
    internal class ConnectionToSQL
    {
        private SqlConnectionStringBuilder sqlBuilder;

        public ConnectionToSQL()
        {
            sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = @"SkyAirlines.mssql.somee.com";
            sqlBuilder.InitialCatalog = "SkyAirlines";
            sqlBuilder.UserID = "TooM_SQLLogin_1";
            sqlBuilder.Password = "li21a3sl6v";
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(sqlBuilder.ConnectionString);
        }
    }
}
