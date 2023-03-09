namespace EmployeeAccountingBusinessLogic.BindingModels;

public class EmployeeBindingModel
{
    public int? Id { get; set; }
    public string? Fullname { get; set; }
    public byte[]? Photo { get; set; }
    public string SkillName { get; set; } = "Не выбран";
    public string? PhoneNumber { get; set; }
}