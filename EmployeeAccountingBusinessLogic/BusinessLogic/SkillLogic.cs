using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.Interfaces;
using EmployeeAccountingBusinessLogic.ViewModels;

namespace EmployeeAccountingBusinessLogic.BusinessLogic
{
    public class SkillLogic
    {
        private readonly ISkillStorage _skillStorage;
        public SkillLogic(ISkillStorage skillStorage)
        {
            _skillStorage = skillStorage;
        }

        public List<SkillViewModel> Read(SkillBindingModel? model)
        {
            if (model == null) return _skillStorage.GetFullList();
            
            if (model.Id.HasValue) return new List<SkillViewModel> {
                _skillStorage.GetElement(model) ?? throw new Exception("Навык не найден")
            };
            
            return _skillStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(SkillBindingModel model)
        {
            if (model == null) throw new Exception("Ошибка при создании записи навыка");

            SkillViewModel? skill = _skillStorage.GetElement(new SkillBindingModel {
                Name = model.Name
            });
            
            if (skill != null && skill.Id != model.Id) throw new Exception("Уже есть навык с таким названием");

            if (model.Id.HasValue)
            {
                _skillStorage.Update(model);
                return;
            }
            
            _skillStorage.Insert(model);
        }
        public void Delete(SkillBindingModel model)
        {
            _skillStorage.Delete(model);
        }
    }
}
