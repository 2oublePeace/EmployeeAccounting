using System.ComponentModel;

namespace EmployeeAccountingBusinessLogic.ViewModels
{
    public class SkillViewModel
    {
        public int? Id { get; set; }
        [DisplayName("Навык")]
        public string? Name { get; set; }
    }
}
