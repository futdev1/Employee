using Employee.Domain.Customs;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DataADO.Contexts
{
    public class DbContext
    {
        private NpgsqlConnection _connection;

        public DbContext()
        {
            _connection = new NpgsqlConnection(Constants.CONNECTION_STRING);
        }

        public async Task<NpgsqlDataReader?> ConnectionAsync(string query)
        {
            NpgsqlCommand command = new NpgsqlCommand(query, _connection);

            if(_connection.State == ConnectionState.Open)
            {
                _connection.Close();    
            }

            else
            {
                await command.ExecuteNonQueryAsync();
            }

            return null;
        }
    }
}
