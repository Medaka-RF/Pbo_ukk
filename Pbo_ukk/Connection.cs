using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pbo_ukk
{
    internal class Connection
    {
        private const string ConnectionString = "Data Source=MYPCPRO;Initial Catalog=db_ukk;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection GetSqlConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            return connection;
        }

    }
}
