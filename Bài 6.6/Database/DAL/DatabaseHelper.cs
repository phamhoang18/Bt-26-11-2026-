using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseHelper
    {
        private static readonly string connectionString = @"Server=.\SQLEXPRESS;Database=BankAtmDB;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}