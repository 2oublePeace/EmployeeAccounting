using EmployeeAccountingBusinessLogic.Enums;

namespace EmployeeAccountingBusinessLogic.BindingModels
{
    public class SkillBindingModel
    {
        public int? Id { get; set; } 
        public string? Name { get; set; }
        public EmployeeSkill Value { get; set; }
    }
}
