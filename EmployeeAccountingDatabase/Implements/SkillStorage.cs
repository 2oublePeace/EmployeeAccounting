using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.Interfaces;
using EmployeeAccountingBusinessLogic.ViewModels;

namespace EmployeeAccountingDatabase.Implements
{
    public class SkillStorage : ISkillStorage
    {
        public SkillViewModel? GetElement(SkillBindingModel model)
        {
            if (model == null)
            {
                throw new Exception("Ошибка при поиске записи навыка");
            }
            using (var context = new EmployeeAccountingDatabaseContext())
            {
                var skill = context.Skills.FirstOrDefault(skill => skill.Name == model.Name || skill.Id == model.Id);

                return skill != null ?
                new SkillViewModel
                {
                    Id = skill.Id,
                    Name = skill.Name,
                    Value = skill.Value
                } :
                null;
            }
        }

        public List<SkillViewModel> GetFilteredList(SkillBindingModel model)
        {
            throw new NotImplementedException();
        }

        public List<SkillViewModel> GetFullList()
        {
            throw new NotImplementedException();
        }

        public void Insert(SkillBindingModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(SkillBindingModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(SkillBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
