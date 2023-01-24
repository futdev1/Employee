using Employee.ADONET.Data.IRepositories;
using Employee.Domain.Customs;
using Employee.Domain.Entities;
using Employee.Domain.Enums;
using Npgsql;
using NpgsqlTypes;

namespace Employee.ADONET.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        NpgsqlConnection connection;

        public EmployeeRepository()
        {
            connection = new NpgsqlConnection(Constants.CONNECTION_STRING);
        }

        public Task CreateAsync(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<EmployeeModel>> GetAllAsync(int from, int to)
        {
            IList<EmployeeModel> employees = new List<EmployeeModel>();

            using (var connection = new NpgsqlConnection(Constants.CONNECTION_STRING))
            {
                var command = new NpgsqlCommand("public.getlimited", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("_from", NpgsqlDbType.Integer).Value = DBNull.Value;
                command.Parameters.Add("_to", NpgsqlDbType.Integer).Value = DBNull.Value;

                await connection.OpenAsync();

                using (NpgsqlDataReader? reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new EmployeeModel()
                        {
                            id = reader.GetInt32(0),
                            name = reader.GetString(1),
                            current_city = reader.GetString(2),
                            department = reader.GetString(3),
                            gender_type = reader.GetInt32(4) == 0 ? Gender.Male : Gender.Female
                        });
                    }
                }
            }

            return employees;
        }
    }
}
