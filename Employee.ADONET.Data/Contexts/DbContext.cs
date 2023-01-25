using Employee.Domain.Customs;
using Npgsql;

namespace Employee.ADONET.Data.Contexts
{
    public class DbContext
    {
        private NpgsqlConnection connection;

        public DbContext()
        {
            connection = new NpgsqlConnection(Constants.CONNECTION_STRING);
            connection.Open();
        }
    }
}
