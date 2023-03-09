using System.ComponentModel.DataAnnotations;

namespace EmployeeAccountingDatabase.Models;

public class Employee
{
    public int Id { get; set; }
    public string? Fullname { get; set; }
    public byte[]? Photo { get; set; }
    public string? PhoneNumber { get; set; }
    public int? SkillId { get; set; }
    public Skill? Skill { get; set; }
}