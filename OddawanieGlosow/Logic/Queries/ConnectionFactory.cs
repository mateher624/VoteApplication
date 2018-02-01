using System.Data.Common;
using System.Data.SqlClient;

namespace OddawanieGlosow.Logic.Queries
{
    public class ConnectionFactory
    {
        public DbConnection OpenConnection()
        {
            var connectionString = 
                System.Configuration.ConfigurationManager.ConnectionStrings["VoteDbContext"].ConnectionString;

            var connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}