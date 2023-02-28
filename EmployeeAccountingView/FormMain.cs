using ControlsLibraryNet60.Models;
using EmployeeAccountingBusinessLogic.BusinessLogic;
using System.Windows.Forms;


namespace EmployeeAccountingView
{
    public partial class FormMain : Form
    {
        EmployeeLogic _employeeLogic;
        public FormMain(EmployeeLogic employeeLogic)
        {
            InitializeComponent();
            _employeeLogic = employeeLogic;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            InitializeTable();
            employeeDataTable.AddTable(_employeeLogic.Read(null));
             
        }

        public void InitializeTable()
        {
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
                    Visible = true
                },
                new DataTableColumnConfig()
                {
                    ColumnHeader = "�����",
                    PropertyName = "Skill",
                    Width = 257,
                    Visible = true
                },
                new DataTableColumnConfig()
                {
                    ColumnHeader = "����� ��������",
                    PropertyName = "PhoneNumber",
                    Width = 257,
                    Visible = true
                }
            };

            employeeDataTable.LoadColumns(dataTableColumnConfigs);
        }
    }
}