using Employee.Domain.Customs;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.ADONET.Data.Contexts
{
    public class DbContext
    {
        private NpgsqlConnection connection;

        public DbContext()
        {
            connection = new NpgsqlConnection(Constants.CONNECTION_STRING);
        }

        public async Task<NpgsqlDataReader> ConnectionAsync(string query)
        {
            NpgsqlCommand command = new NpgsqlCommand(query, connection);

            if (connection.State == ConnectionState.Open)
                connection.Close();

            else
            {
                connection.Open();

                if (query.Contains("SELECT"))
                    return await command.ExecuteReaderAsync();
                else
                    await command.ExecuteNonQueryAsync();

                connection.Close();
            }
            return null;
        }
        
    }
}
