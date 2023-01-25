using Employee.Domain.Entities;

namespace Employee.ADONET.Service.Interfaces
{
    public interface IEmployeeService
    {
        Task CreateAsync(EmployeeModel employee);

        Task<IList<EmployeeModel>> GetAllAsync(int from, int to);

        Task<IList<EmployeeModel>> GetAsync(int id);

        Task UpdateAsync(EmployeeModel employee);

        Task DeleteAsync(int id);

        Task DeleteAllAsync();
    }
}
