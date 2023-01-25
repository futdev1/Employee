using Employee.Domain.Entities;
using System.Linq.Expressions;

namespace Employee.Service.Interfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeModel> CreateAsync(EmployeeModel employee);

        Task<EmployeeModel> GetAsync(Expression<Func<EmployeeModel, bool>> expression);

        Task<IQueryable<EmployeeModel>> GetAllAsync(Expression<Func<EmployeeModel, bool>>? expression = null, int pageIndex = 0);

        Task<EmployeeModel> UpdateAsync(EmployeeModel employee);

        Task<bool> DeleteAsync(Expression<Func<EmployeeModel, bool>> expression);

        Task DeleteAllAsync();
    }
}
