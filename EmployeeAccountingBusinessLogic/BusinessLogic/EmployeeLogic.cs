using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.Interfaces;
using EmployeeAccountingBusinessLogic.ViewModels;

namespace EmployeeAccountingBusinessLogic.BusinessLogic;

public class EmployeeLogic
{
    private readonly IEmployeeStorage _employeeStorage;

    public EmployeeLogic(IEmployeeStorage employeeStorage)
    {
        _employeeStorage = employeeStorage;
    }

    public List<EmployeeViewModel> Read(EmployeeBindingModel? model)
    {
        if (model == null) return _employeeStorage.GetFullList();

        if (model.Id.HasValue) return new List<EmployeeViewModel> { 
            _employeeStorage.GetElement(model) ?? throw new Exception("Сотрудник не найден")
        };
        
        return _employeeStorage.GetFilteredList(model);
    }

    public void CreateOrUpdate(EmployeeBindingModel model)
    {
        if (model == null) throw new Exception("Ошибка при создании записи сотрудника");

        EmployeeViewModel? employee = _employeeStorage.GetElement(new EmployeeBindingModel
        {
            Fullname = model.Fullname
        });

        if (employee != null && employee.Id != model.Id) throw new Exception("Уже есть сотрудник с таким ФИО");
        
        if (model.Id.HasValue)
        {
            _employeeStorage.Update(model);
            return;
        }
        
        _employeeStorage.Insert(model);
    }

    public void Delete(EmployeeBindingModel model)
    {
        _employeeStorage.Delete(model);
    }
}
