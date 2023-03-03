using EmployeeAccountingDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAccountingDatabase
{
    public class EmployeeAccountingDatabaseContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Skill> Skills => Set<Skill>();

        public EmployeeAccountingDatabaseContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=employee_accounting.db");
        }
    }
}