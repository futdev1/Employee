using Employee.ADONET.Data.IRepositories;
using Employee.Domain.Customs;
using Employee.Domain.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.ADONET.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        NpgsqlConnection connection;

        public EmployeeRepository()
        {
            connection = new NpgsqlConnection(Constants.CONNECTION_STRING);
        }

        public async Task CreateAsync(EmployeeModel employee)
        {
            connection.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("call add_employee('Akmal', 'Komilov', 'Chilonzor', 0)", connection);
            await connection.CloseAsync();
        }
    }
}
