using Employee.Data.Context;
using Employee.Data.IRepositories;
using Employee.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Employee.Data.Repositories
{
#pragma warning disable
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeDbContext dbContext;
        private DbSet<EmployeeModel> dbSet;

        public EmployeeRepository()
        {
            dbContext = new EmployeeDbContext();
            dbSet = dbContext.Set<EmployeeModel>();
        }

        public async Task<EmployeeModel> CreateAsync(EmployeeModel employee)
        {
            var entry = await dbContext.AddAsync(employee);

            await dbContext.SaveChangesAsync();

            return entry.Entity;
        }

        public async Task DeleteAllAsync()
        {
            EmployeeDbContext dbContext = new EmployeeDbContext();
            var records = from m in dbContext.Employees
                          select m;
            foreach (var record in records)
            {
                dbContext.Employees.Remove(record);
            }
            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(Expression<Func<EmployeeModel, bool>> expression)
        {
            var entity = await dbSet.FirstOrDefaultAsync(expression);

            if (entity is null)
                return false;

            dbSet.Remove(entity);

            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<IQueryable<EmployeeModel>> GetAllAsync(Expression<Func<EmployeeModel, bool>>? expression = null)
        {
            return expression == null ? dbSet : dbSet.Where(expression);
        }

        public async Task<EmployeeModel> GetAsync(Expression<Func<EmployeeModel, bool>> expression)
            => await dbSet.FirstOrDefaultAsync(expression);

        public async Task<EmployeeModel> UpdateAsync(EmployeeModel employee)
        {
            var updatedEntity = dbSet.Update(employee);

            await dbContext.SaveChangesAsync();

            return updatedEntity.Entity;
        }
    }
}
