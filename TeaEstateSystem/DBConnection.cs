using System.Data.SqlClient;

namespace TeaEstateSystem
{
    public class DBConnection
    {
        private string connStr =
            "Server=localhost\\SQLEXPRESS;Database=TeaEstateDB;Trusted_Connection=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }
    }
}