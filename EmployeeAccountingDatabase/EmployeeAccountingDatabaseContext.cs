using EmployeeAccountingBusinessLogic.Enums;
using EmployeeAccountingDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAccountingDatabase
{
    public class EmployeeAccountingDatabaseContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Skill> Skills => Set<Skill>();

        public EmployeeAccountingDatabaseContext() {
            
            if (Database.EnsureCreated())
            {
                using (var context = new EmployeeAccountingDatabaseContext())
                {
                    foreach (var skill in Enum.GetValues<EmployeeSkill>())
                    {
                        context.Add(new Skill()
                        {
                            Name = Enum.GetName(skill),
                            Value = skill
                        });
                    }
                    context.SaveChanges();
                } 
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=employee_accounting.db");
        }
    }
}