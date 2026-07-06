using System.Configuration;
using System.Data.SqlClient;

namespace TeaEstateSystem
{
    public class DBConnection
    {
        private readonly string connStr =
            ConfigurationManager.ConnectionStrings["TeaEstateDB"].ConnectionString;

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }
    }
}