using EmployeeAccountingBusinessLogic.Enums;

namespace EmployeeAccountingBusinessLogic.ViewModels
{
    public class SkillViewModel
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public EmployeeSkill Value { get; set; }
    }
}
