using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.Interfaces;
using EmployeeAccountingBusinessLogic.ViewModels;
using EmployeeAccountingDatabase.Models;

namespace EmployeeAccountingDatabase.Implements;

public class EmployeeStorage : IEmployeeStorage
{
    public List<EmployeeViewModel> GetFullList()
    {
        using var context = new EmployeeAccountingDatabaseContext();

        return context.Employees
            .Select(employee => new EmployeeViewModel {
                Id = employee.Id,
                Fullname = employee.Fullname,
                Photo = employee.Photo,
                SkillName = context.Skills.FirstOrDefault(skill => skill.Id == employee.SkillId).Name,
                PhoneNumber = employee.PhoneNumber
            })
            .ToList();
    }

    public List<EmployeeViewModel> GetFilteredList(EmployeeBindingModel model)
    {
        if (model == null)
            throw new Exception("Ошибка при поиске записей сотрудников");
        
        using var context = new EmployeeAccountingDatabaseContext();
        
        return context.Employees
            .Where(employee => employee.Fullname == model.Fullname)
            .Select(employee => new EmployeeViewModel {
                    Id = employee.Id,
                    Fullname = employee.Fullname,
                    Photo = employee.Photo,
                    SkillName = context.Skills.FirstOrDefault(skill => skill.Id == employee.SkillId).Name,
                    PhoneNumber = employee.PhoneNumber
            })
            .ToList();
    }

    public EmployeeViewModel? GetElement(EmployeeBindingModel model)
    {
        if (model == null)
            throw new Exception("Ошибка при поиске записи сотрудника");
        
        using var context = new EmployeeAccountingDatabaseContext();
        var employee = context.Employees.FirstOrDefault(employee => employee.Fullname == model.Fullname || employee.Id == model.Id);

        return employee != null ?
            new EmployeeViewModel
            {
                Id = employee.Id,
                Fullname = employee.Fullname,
                Photo = employee.Photo,
                SkillName = context.Skills.FirstOrDefault(skill => skill.Id == employee.SkillId).Name,
                PhoneNumber = employee.PhoneNumber
            } :
            null;
    }

    public void Insert(EmployeeBindingModel model)
    {
        if (model == null)
            throw new Exception("Ошибка при создании записи сотрудника");
        

        using var context = new EmployeeAccountingDatabaseContext();

        context.Add(new Employee {
            Fullname = model.Fullname,
            Photo = model.Photo,
            SkillId = context.Skills.FirstOrDefault(skill => skill.Name == model.SkillName).Id,
            PhoneNumber = model.PhoneNumber
        });
        context.SaveChanges();
    }

    public void Update(EmployeeBindingModel model)
    {
        if (model == null)
            throw new Exception("Ошибка при обновлении записи сотрудника");
        
        using var context = new EmployeeAccountingDatabaseContext();
        var employee = context.Employees.FirstOrDefault(employee => employee.Id == model.Id) ??
            throw new Exception("Сотрудник не найден");

        employee.Fullname = model.Fullname;
        employee.Photo = model.Photo;
        employee.SkillId = context.Skills.FirstOrDefault(skill => skill.Name == model.SkillName).Id;
        employee.PhoneNumber = model.PhoneNumber;
        
        context.SaveChanges();
    }

    public void Delete(EmployeeBindingModel model)
    {
        if (model == null)
            throw new Exception("Ошибка при удалении записи сотрудника");
        

        using var context = new EmployeeAccountingDatabaseContext();
        var employee = context.Employees.FirstOrDefault(employee => employee.Id == model.Id) ??
            throw new Exception("Сотрудник не найден");

        context.Employees.Remove(employee);
        context.SaveChanges();
    }
}