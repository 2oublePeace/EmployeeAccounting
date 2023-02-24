using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.ViewModels;

namespace EmployeeAccountingBusinessLogic.Interfaces;

public interface IEmployeeStorage
{
    List<EmployeeViewModel> GetFullList();
    List<EmployeeViewModel> GetFilteredList(EmployeeBindingModel model);
    EmployeeViewModel GetElement(EmployeeBindingModel model);
    void Insert(EmployeeBindingModel model);
    void Update(EmployeeBindingModel model);
    void Delete(EmployeeBindingModel model);
}