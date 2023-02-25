using EmployeeAccountingBusinessLogic.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAccountingDatabase.Models;

public class Employee
{
    [Key]
    public int? Id { get; set; }
    [Required]
    public string? Fullname { get; set; }
    public byte[]? Photo { get; set; }
    [Required]
    public EmployeeSkill? Skill { get; set; }
    [Required]
    public string? PhoneNumber { get; set; }
}