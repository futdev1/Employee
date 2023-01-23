using Employee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DataADO.IRepositories
{
    public interface IEmployeeRepository
    {
        Task CreateAsync(EmployeeModel employee);

        Task UpdateAsync(EmployeeModel employee);

        Task DeleteAsync(long id);

        Task<EmployeeModel> GetAsync(int id);

        Task<IQueryable<EmployeeModel>> GetAllAsync(int from, int to);
    }
}
