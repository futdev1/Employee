using Employee.DataADO.Contexts;
using Employee.DataADO.IRepositories;
using Employee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DataADO.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private DbContext dbContext;

        public EmployeeRepository()
        {
            dbContext = new DbContext();
        }
        public async Task CreateAsync(EmployeeModel employee)
        {
            await dbContext.ConnectionAsync(

                "INSERT INTO employees (name, currentcity, department, gendertype)" +
                $"VALUES('{employee.Name}', '{employee.CurrentCity}', '{employee.Department}', '{employee.GenderType}'"

                );
        }

        public async Task DeleteAsync(long id)
        {
            await dbContext.ConnectionAsync($"DELETE FROM Employees where Id = {id}::integer");
        }

        public async Task<IQueryable<EmployeeModel>> GetAllAsync(int from, int to)
        {
            IEnumerable<EmployeeModel> employees = new Enumerable<EmployeeModel>();
        }

        public Task<EmployeeModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }
    }
}
