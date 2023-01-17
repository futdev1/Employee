using Employee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
