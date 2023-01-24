
using Employee.Domain.Entities;

namespace Employee.ADONET.Data.IRepositories
{
    public interface IEmployeeRepository
    {
        void CreateAsync(EmployeeModel employee);

       IList<EmployeeModel> GetAllAsync(int from, int to);

        Task<EmployeeModel> GetAsync(int id);

        void UpdateAsync(EmployeeModel employee);

        void DeleteAsync(int id);

    }
}
