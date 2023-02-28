using EmployeeAccountingBusinessLogic.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EmployeeAccountingDatabase.Models
{
    public class Skill
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public EmployeeSkill Value { get; set; }
        [ForeignKey("SkillId")]
        public virtual List<Employee>? Employees { get; set; }
    }
}
