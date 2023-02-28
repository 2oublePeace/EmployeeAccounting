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

        public List<SkillViewModel> Read(SkillBindingModel model)
        {
            if (model == null)
            {
                return _skillStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<SkillViewModel> { _skillStorage.GetElement(model) };
            }
            return _skillStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(SkillBindingModel model)
        {
            var skill = _skillStorage.GetElement
            (
                new SkillBindingModel
                {
                    Name = model.Name
                }
            );
            if (skill != null && skill.Id != model.Id)
            {
                throw new Exception("Уже есть навык с таким названием");
            }
            if (model.Id.HasValue)
            {
                _skillStorage.Update(model);
            }
            else
            {
                _skillStorage.Insert(model);
            }
        }
        public void Delete(SkillBindingModel model)
        {
            var skill = _skillStorage.GetElement(new SkillBindingModel { Id = model.Id });
            if (skill == null)
            {
                throw new Exception("Навык не найден");
            }
            _skillStorage.Delete(model);
        }
    }
}
