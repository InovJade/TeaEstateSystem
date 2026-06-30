using MySql.Data.MySqlClient;

namespace TeaEstateSystem
{
    public class DBConnection
    {
        private string connectionString =
            "server=localhost;database=TeaEstateDB;uid=root;pwd=Samantha@112233;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}