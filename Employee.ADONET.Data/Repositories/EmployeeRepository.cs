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
        public async Task CreateAsync(EmployeeModel employee)
        {
            using (var connection = new NpgsqlConnection(Constants.CONNECTION_STRING))
            {
                var command = new NpgsqlCommand("public.add_employee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_name", NpgsqlDbType.Varchar).Value = employee.name;
                command.Parameters.Add("_current_city", NpgsqlDbType.Varchar).Value = employee.current_city;
                command.Parameters.Add("_department", NpgsqlDbType.Varchar).Value = employee.department;
                command.Parameters.Add("_gender_type", NpgsqlDbType.Integer).Value = employee.gender_type == Gender.Male ? 0 : 1;
                connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task DeleteAllAsync()
        {
            using (var connection = new NpgsqlConnection(Constants.CONNECTION_STRING))
            {
                var command = new NpgsqlCommand("public.delete_all", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var connection = new NpgsqlConnection(Constants.CONNECTION_STRING))
            {
                var command = new NpgsqlCommand("public.delete_employee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;
                connection.Open();
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task<IList<EmployeeModel>> GetAllAsync(int from, int to)
        {
            IList<EmployeeModel> employees = new List<EmployeeModel>();

            using (var connection = new NpgsqlConnection(Constants.CONNECTION_STRING))
            {
                var command = new NpgsqlCommand($"select * from getlimited({from}, {to})", connection);
                command.CommandType = CommandType.Text;
                //command.Parameters.Add("_to", NpgsqlDbType.Integer).Value = to;
                //command.Parameters.Add("_from", NpgsqlDbType.Integer).Value = from;

                await connection.OpenAsync();

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
                            gender_type = reader.GetString(4) == "0" ? Gender.Male : Gender.Female
                        });
                    }
                }
            }

            return employees;
        }

        public async Task<IList<EmployeeModel>> GetAsync(int id)
        {
            IList<EmployeeModel> employees = new List<EmployeeModel>();

            using (var connection = new NpgsqlConnection(Constants.CONNECTION_STRING))
            {
                var command = new NpgsqlCommand($"select * from getoneemployee({id})", connection);  
                command.CommandType = CommandType.Text;
                //command.Parameters.AddWithValue("_id", NpgsqlDbType.Integer, id);

                await connection.OpenAsync();

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
                            gender_type = reader.GetString(4) == "0" ? Gender.Male : Gender.Female
                        });
                    }
                }
            }

            return employees.Count <= 0 ? null : employees;
        }

        public async Task UpdateAsync(EmployeeModel employee)
        {
            using (var connection = new NpgsqlConnection(Constants.CONNECTION_STRING))
            {
                var command = new NpgsqlCommand("public.update_employee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_employee_id", NpgsqlDbType.Integer).Value = employee.id;
                command.Parameters.Add("_name", NpgsqlDbType.Varchar).Value = employee.name;
                command.Parameters.Add("_current_city", NpgsqlDbType.Varchar).Value = employee.current_city;
                command.Parameters.Add("_department", NpgsqlDbType.Varchar).Value = employee.department;
                command.Parameters.Add("_gender_type", NpgsqlDbType.Integer).Value = employee.gender_type == Gender.Male ? 0 : 1;
                connection.OpenAsync();
               
                await command.ExecuteNonQueryAsync();
            }
        }
    }
}
