
using Employee.Domain.Entities;

namespace Employee.ADONET.Data.IRepositories
{
    public interface IEmployeeRepository
    {
        Task CreateAsync(EmployeeModel employee);

       IList<EmployeeModel> GetAllAsync(int from, int to);

        Task<EmployeeModel> GetAsync(int id);

        Task UpdateAsync(EmployeeModel employee);

        Task DeleteAsync(int id);

    }
}
