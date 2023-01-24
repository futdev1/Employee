using Employee.ADONET.Data.IRepositories;
using Employee.Domain.Customs;
using Employee.Domain.Entities;
using Employee.Domain.Enums;
using Npgsql;
using NpgsqlTypes;
using System.Data;

namespace Employee.ADONET.Data.Repositories
{
#pragma warning disable
    public class EmployeeRepository : IEmployeeRepository
    {
        public void CreateAsync(EmployeeModel employee)
        {
            using (var connection = new NpgsqlConnection(Constants.CONNECTION_STRING))
            {
                var command = new NpgsqlCommand("public.add_employee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_name", NpgsqlDbType.Varchar).Value = employee.name;
                command.Parameters.Add("_current_city", NpgsqlDbType.Varchar).Value = employee.current_city;
                command.Parameters.Add("_department", NpgsqlDbType.Varchar).Value = employee.department;
                command.Parameters.Add("_gender_type", NpgsqlDbType.Integer).Value = employee.gender_type == Gender.Male ? 0 : 1;
            }
        }

        public void DeleteAsync(int id)
        {
            using (var connection = new NpgsqlConnection(Constants.CONNECTION_STRING))
            {
                var command = new NpgsqlCommand("public.delete_employee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IList<EmployeeModel> GetAllAsync(int from, int to)
        {
            IList<EmployeeModel> employees = new List<EmployeeModel>();

            using (var connection = new NpgsqlConnection(Constants.CONNECTION_STRING))
            {
                var command = new NpgsqlCommand("getlimited", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_to", NpgsqlDbType.Integer).Value = to;
                command.Parameters.Add("_from", NpgsqlDbType.Integer).Value = from;

                connection.Open();

                using (var reader = command.ExecuteReader())
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

        public Task<EmployeeModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsync(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }
    }
}
