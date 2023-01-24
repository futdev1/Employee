using Employee.Data.IRepositories;
using Employee.Data.Repositories;
using Employee.Domain.Entities;
using Employee.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository repository;

        public EmployeeService()
        {
            repository = new EmployeeRepository();
        }

        public async Task<EmployeeModel> CreateAsync(EmployeeModel employee)
        {
            return await repository.CreateAsync(employee);
        }

        public async Task DeleteAllAsync()
        {
            await repository.DeleteAllAsync();
        }

        public Task<bool> DeleteAsync(Expression<Func<EmployeeModel, bool>> expression)
        {
            return repository.DeleteAsync(expression);
        }

        public async Task<IQueryable<EmployeeModel>?> GetAllAsync(Expression<Func<EmployeeModel, bool>> expression = null, int pageIndex = 0)
        {
            if(pageIndex > 0)
            {
                return await repository.GetAllAsync(expression, pageIndex);
            }
            else
            {
                return null;
            }

        }

        public async Task<EmployeeModel> GetAsync(Expression<Func<EmployeeModel, bool>> expression)
        {
            return await repository.GetAsync(expression);
        }

        public async Task<EmployeeModel> UpdateAsync(EmployeeModel employee)
        {
            var result = await repository.GetAsync(p => p.id == employee.id);

            if (result is not null)
            {
                result.id = employee.id;
                result.name = employee.name;
                result.current_city = employee.current_city;
                result.department = employee.department;
                result.gender_type = employee.gender_type;

                return await repository.UpdateAsync(result);
            }
            else
                return null;

        }
    }
}
