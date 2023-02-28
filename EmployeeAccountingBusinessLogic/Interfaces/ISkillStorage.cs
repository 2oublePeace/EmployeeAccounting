using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.ViewModels;

namespace EmployeeAccountingBusinessLogic.Interfaces
{
    public interface ISkillStorage
    {
        List<SkillViewModel> GetFullList();
        List<SkillViewModel> GetFilteredList(SkillBindingModel model);
        SkillViewModel? GetElement(SkillBindingModel model);
        void Insert(SkillBindingModel model);
        void Update(SkillBindingModel model);
        void Delete(SkillBindingModel model);
    }
}
