using Employee.ADONET.Data.IRepositories;
using Employee.ADONET.Data.Repositories;
using Employee.ADONET.Service.Interfaces;
using Employee.Domain.Entities;

namespace Employee.ADONET.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository employeeRepository;

        public EmployeeService()
        {
            employeeRepository = new EmployeeRepository();
        }
        public async Task CreateAsync(EmployeeModel employee)
        {
            await employeeRepository.CreateAsync(employee);
        }

        public async Task DeleteAllAsync()
        {
            await employeeRepository.DeleteAllAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await employeeRepository.DeleteAsync(id);
        }

        public async Task<IList<EmployeeModel>> GetAllAsync(int from, int to)
        {
            return await employeeRepository.GetAllAsync(from, to);
        }

        public async Task<IList<EmployeeModel>> GetAsync(int id)
        {
            return await employeeRepository.GetAsync(id);
        }

        public async Task UpdateAsync(EmployeeModel employee)
        {
            var result = await employeeRepository.GetAsync((int)employee.id);

            EmployeeModel model = result[0];

            if (result[0] is not null)
            {
                model.id = employee.id;
                model.name = employee.name;
                model.current_city = employee.current_city;
                model.department = employee.department;
                model.gender_type = employee.gender_type;

                await employeeRepository.UpdateAsync(model);
            }
            else { }
        }
    }
}
