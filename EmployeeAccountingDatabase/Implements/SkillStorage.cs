using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.Interfaces;
using EmployeeAccountingBusinessLogic.ViewModels;
using EmployeeAccountingDatabase.Models;
using System.Xml.Linq;

namespace EmployeeAccountingDatabase.Implements
{
    public class SkillStorage : ISkillStorage
    {
        public SkillViewModel? GetElement(SkillBindingModel model)
        {
            if (model == null)
                throw new Exception("Ошибка при поиске записи навыка");

            using var context = new EmployeeAccountingDatabaseContext();
            var skill = context.Skills.FirstOrDefault(skill => skill.Name == model.Name || skill.Id == model.Id);

            return skill != null ?
                new SkillViewModel
                {
                    Id = skill.Id,
                    Name = skill.Name
                } :
                null;
        }

        public List<SkillViewModel> GetFilteredList(SkillBindingModel model)
        {
            if (model == null)
                throw new Exception("Ошибка при поиске записей навыков");

            using var context = new EmployeeAccountingDatabaseContext();
            
            return context.Skills
                .Where(skill => skill.Name == model.Name)
                .Select(skill => new SkillViewModel {
                    Id = skill.Id,
                    Name = skill.Name
                })
                .ToList();
        }

        public List<SkillViewModel> GetFullList()
        {
            using var context = new EmployeeAccountingDatabaseContext();
            
            return context.Skills
                .Select(skill => new SkillViewModel {
                    Id = skill.Id,
                    Name = skill.Name
                })
                .ToList();
        }

        public void Insert(SkillBindingModel model)
        {
            if (model == null)
                throw new Exception("Ошибка при создании записи навыка");

            using var context = new EmployeeAccountingDatabaseContext();
            
            context.Add(new Skill {
                Id = model.Id,
                Name = model.Name
            });
            context.SaveChanges();
        }

        public void Update(SkillBindingModel model)
        {
            if (model == null)
                throw new Exception("Ошибка при обновлении записи навыка");

            using var context = new EmployeeAccountingDatabaseContext();
            var skill = context.Skills.FirstOrDefault(skill => skill.Id == model.Id) ?? 
                throw new Exception("Навык не найден");
            
            skill.Id = model.Id;
            skill.Name = model.Name;
            
            context.SaveChanges();
        }

        public void Delete(SkillBindingModel model)
        {
            if (model == null)
                throw new Exception("Ошибка при удалении записи навыка");

            using var context = new EmployeeAccountingDatabaseContext();
            var skill = context.Skills.FirstOrDefault(skill => skill.Id == model.Id) ??
                throw new Exception("Навык не найден");
            
            context.Skills.Remove(skill);
            context.SaveChanges();
        }
    }
}
