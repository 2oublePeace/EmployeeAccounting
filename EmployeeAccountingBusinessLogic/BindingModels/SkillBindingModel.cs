using EmployeeAccountingBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccountingBusinessLogic.BindingModels
{
    public class SkillBindingModel
    {
        public int? Id { get; set; } 
        public string? Name { get; set; }
        public EmployeeSkill Value { get; set; }
    }
}
