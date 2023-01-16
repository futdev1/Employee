using Employee.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employee.Data.Context
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<EmployeeModel> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Domain.Customs.Constants.CONNECTION_STRING);
        }
    }
}
