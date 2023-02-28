using EmployeeAccountingBusinessLogic.Enums;

namespace EmployeeAccountingBusinessLogic.BindingModels;

public class EmployeeBindingModel
{
    public int? Id { get; set; }
    public string? Fullname { get; set; }
    public byte[]? Photo { get; set; }
    public int? SkillId { get; set; }
    public string? SkillName { get; set; }
    public string? PhoneNumber { get; set; }
}