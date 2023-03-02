using EmployeeAccountingBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccountingBusinessLogic.ViewModels
{
    public class EmployeeReportViewModel
    {
        public int? Id { get; set; }
        public string? Fullname { get; set; }
        public EmployeeSkill? Skill { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
