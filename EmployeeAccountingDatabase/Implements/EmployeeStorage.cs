using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.Interfaces;
using EmployeeAccountingBusinessLogic.ViewModels;
using EmployeeAccountingDatabase.Models;

namespace EmployeeAccountingDatabase.Implements;

public class EmployeeStorage : IEmployeeStorage
{
    public List<EmployeeViewModel> GetFullList()
    {
        using (var context = new EmployeeAccountingDatabaseContext())
        {
            return context.Employees
                .Select
                (
                    employee => new EmployeeViewModel()
                    {
                        Id = employee.Id,
                        Fullname = employee.Fullname
                    }
                )
                .ToList();
        }
    }

    public List<EmployeeViewModel> GetFilteredList(EmployeeBindingModel model)
    {
        throw new NotImplementedException();
    }

    public EmployeeViewModel GetElement(EmployeeBindingModel model)
    {
        throw new NotImplementedException();
    }

    public void Insert(EmployeeBindingModel model)
    {
        using (var context = new EmployeeAccountingDatabaseContext())
        {
            context.Add(new Employee()
                {
                    Id = model.Id,
                    Fullname = model.Fullname
                }
            );
            context.SaveChanges();
        }
    }

    public void Update(EmployeeBindingModel model)
    {
        throw new NotImplementedException();
    }

    public void Delete(EmployeeBindingModel model)
    {
        throw new NotImplementedException();
    }
}