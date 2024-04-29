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
            sqlBuilder.DataSource = @"SQL Server";
            sqlBuilder.InitialCatalog = "Database Name";
            sqlBuilder.UserID = "User";
            sqlBuilder.Password = "Password";
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(sqlBuilder.ConnectionString);
        }
    }
}
