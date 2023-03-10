using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.Interfaces;
using EmployeeAccountingBusinessLogic.ViewModels;
using EmployeeAccountingDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAccountingDatabase.Implements;

public class EmployeeStorage : IEmployeeStorage
{
    public List<EmployeeViewModel> GetFullList()
    {
        using var context = new EmployeeAccountingDatabaseContext();
        
        return context.Employees
            .Include(employee => employee.Skill)
            .Select(employee => new EmployeeViewModel {
                Id = employee.Id,
                Fullname = employee.Fullname,
                Photo = employee.Photo,
                SkillName = employee.Skill != null ? employee.Skill.Name : "Не выбран",
                PhoneNumber = employee.PhoneNumber
            })
            .ToList();
    }

    public List<EmployeeViewModel> GetFilteredList(EmployeeBindingModel model)
    {       
        using var context = new EmployeeAccountingDatabaseContext();
        
        return context.Employees
            .Include(employee => employee.Skill)
            .Where(employee => employee.Skill != null && employee.Skill.Name == model.SkillName)
            .Select(employee => new EmployeeViewModel {
                Id = employee.Id,
                Fullname = employee.Fullname,
                Photo = employee.Photo,
                SkillName = employee.Skill != null ? employee.Skill.Name : "Не выбран",
                PhoneNumber = employee.PhoneNumber
            })
            .ToList();
    }

    public EmployeeViewModel? GetElement(EmployeeBindingModel model)
    { 
        using var context = new EmployeeAccountingDatabaseContext();
        Employee? employee = context.Employees
            .Include(employee => employee.Skill)
            .FirstOrDefault(employee => employee.Id == model.Id || employee.Fullname == model.Fullname);

        return employee != null ?
            new EmployeeViewModel
            {
                Id = employee.Id,
                Fullname = employee.Fullname,
                Photo = employee.Photo,
                SkillName = employee.Skill != null ? employee.Skill.Name : "Не выбран",
                PhoneNumber = employee.PhoneNumber
            } :
            null;
    }

    public void Insert(EmployeeBindingModel model)
    {
        using var context = new EmployeeAccountingDatabaseContext();

        context.Add(new Employee {
            Fullname = model.Fullname,
            Photo = model.Photo,
            SkillId = context.Skills.FirstOrDefault(skill => skill.Name == model.SkillName)!.Id,
            Skill = context.Skills.FirstOrDefault(skill => skill.Name == model.SkillName)!,
            PhoneNumber = model.PhoneNumber
        });
        context.SaveChanges();
    }

    public void Update(EmployeeBindingModel model)
    {
        using var context = new EmployeeAccountingDatabaseContext();
        Employee employee = context.Employees.FirstOrDefault(employee => employee.Id == model.Id) ??
            throw new Exception("Сотрудник не найден");

        employee.Fullname = model.Fullname;
        employee.Photo = model.Photo;
        employee.SkillId = context.Skills.FirstOrDefault(skill => skill.Name == model.SkillName)!.Id;
        employee.Skill = context.Skills.FirstOrDefault(skill => skill.Name == model.SkillName)!;
        employee.PhoneNumber = model.PhoneNumber;
        
        context.SaveChanges();
    }

    public void Delete(EmployeeBindingModel model)
    { 
        using var context = new EmployeeAccountingDatabaseContext();
        Employee employee = context.Employees.FirstOrDefault(employee => employee.Id == model.Id) ??
            throw new Exception("Сотрудник не найден");

        context.Employees.Remove(employee);
        context.SaveChanges();
    }
}