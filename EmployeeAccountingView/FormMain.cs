using ControlsLibraryNet60.Models;
using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.Enums;
using EmployeeAccountingBusinessLogic.ViewModels;

namespace EmployeeAccountingView
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            List<EmployeeViewModel> employees = new List<EmployeeViewModel>()
            {
                new EmployeeViewModel()
                {
                    Id= 1,
                    Fullname = "Zhizha",
                    Skill = EmployeeSkill.���������,
                    PhoneNumber = "fdf23fsdf"
                },
                new EmployeeViewModel()
                {
                    Id= 2,
                    Fullname = "Zhiasdaszha",
                    Skill = EmployeeSkill.���������,
                    PhoneNumber = "fdfdsfsdf"
                },
                new EmployeeViewModel()
                {
                    Id= 3,
                    Fullname = "Zhizss22ha",
                    Skill = EmployeeSkill.���������,
                    PhoneNumber = "fdfds122fsdf"
                }
            };


            List<DataTableColumnConfig> dataTableColumnConfigs = new List<DataTableColumnConfig>()
            {
                new DataTableColumnConfig()
                {
                    ColumnHeader = "�������������",
                    PropertyName = "Id",
                    Width = 257,
                    Visible = false
                },
                new DataTableColumnConfig()
                {
                    ColumnHeader = "���",
                    PropertyName = "Fullname",
                    Width = 257,
                    Visible= true
                },
                new DataTableColumnConfig()
                {
                    ColumnHeader = "�����",
                    PropertyName = "Skill",
                    Width = 257,
                    Visible= true
                },
                new DataTableColumnConfig()
                {
                    ColumnHeader = "����� ��������",
                    PropertyName = "PhoneNumber",
                    Width = 257,
                    Visible= true
                }
            };
            controlDataTableTable1.LoadColumns(dataTableColumnConfigs);
            controlDataTableTable1.AddTable(employees);
        }
    }
}