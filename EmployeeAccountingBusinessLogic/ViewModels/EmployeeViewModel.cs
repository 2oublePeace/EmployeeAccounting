using System.ComponentModel;

namespace EmployeeAccountingBusinessLogic.ViewModels;

public class EmployeeViewModel
{
    public int? Id { get; set; }
    [DisplayName("ФИО")]
    public string? Fullname { get; set; }
    public byte[]? Photo { get; set; }
    [DisplayName("Навык")]
    public string? SkillName { get; set; }
    [DisplayName("Телефон")]
    public string? PhoneNumber { get; set; }
}