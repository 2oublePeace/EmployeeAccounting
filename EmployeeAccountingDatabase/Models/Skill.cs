using EmployeeAccountingBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
