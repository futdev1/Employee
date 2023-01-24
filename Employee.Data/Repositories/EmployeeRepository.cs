using Employee.EFCore.Data.Context;
using Employee.Data.IRepositories;
using Employee.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Employee.Data.Repositories
{
#pragma warning disable
    public class EmployeeRepository : IEmployeeRepository
    {
        #region private
        private EmployeeDbContext dbContext;
        private DbSet<EmployeeModel> dbSet;
        #endregion

        //constructor
        public EmployeeRepository()
        {
            dbContext = new EmployeeDbContext();
            dbSet = dbContext.Set<EmployeeModel>();
        }

        /// <summary>
        /// Add to database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task<EmployeeModel> CreateAsync(EmployeeModel employee)
        {
            var entry = await dbContext.AddAsync(employee);

            await dbContext.SaveChangesAsync();

            return entry.Entity;
        }

        /// <summary>
        /// Delete all data in the database
        /// </summary>
        /// <returns></returns>
        public async Task DeleteAllAsync()
        {
           
            dbContext.Employees.RemoveRange(dbContext.Employees.ToList());
            await dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Delete from database
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(Expression<Func<EmployeeModel, bool>> expression)
        {
            var entity = await dbSet.FirstOrDefaultAsync(expression);

            if (entity is null)
                return false;

            dbSet.Remove(entity);

            await dbContext.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// Get all Employee data with queryable
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<IQueryable<EmployeeModel>> GetAllAsync(Expression<Func<EmployeeModel, bool>>? expression = null, int pageIndex = 1)
        {
            var result = expression == null ? dbSet : dbSet.Where(expression);

            return result.Skip((pageIndex - 1) * 12).Take(12);
        }

        /// <summary>
        /// return Employee data 
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<EmployeeModel> GetAsync(Expression<Func<EmployeeModel, bool>> expression)
            => await dbSet.FirstOrDefaultAsync(expression);

        /// <summary>
        /// update employee data from database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task<EmployeeModel> UpdateAsync(EmployeeModel employee)
        {
            var updatedEntity = dbSet.Update(employee);

            await dbContext.SaveChangesAsync();

            return updatedEntity.Entity;
        }
    }
}
