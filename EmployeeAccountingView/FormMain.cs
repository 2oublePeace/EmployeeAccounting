using ControlsLibraryNet60.Models;
using EmployeeAccountingBusinessLogic.BusinessLogic;


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
            controlDataTable.AddTable(_employeeLogic.Read(null));
        }

        public void InitializeTable()
        {
            List<DataTableColumnConfig> dataTableColumnConfigs = new List<DataTableColumnConfig>()
            {
                new DataTableColumnConfig()
                {
                    ColumnHeader = "Идентификатор",
                    PropertyName = "Id",
                    Width = 257,
                    Visible = false
                },
                new DataTableColumnConfig()
                {
                    ColumnHeader = "ФИО",
                    PropertyName = "Fullname",
                    Width = 257,
                    Visible = true
                },
                new DataTableColumnConfig()
                {
                    ColumnHeader = "Навык",
                    PropertyName = "Skill",
                    Width = 257,
                    Visible = true
                },
                new DataTableColumnConfig()
                {
                    ColumnHeader = "Номер телефона",
                    PropertyName = "PhoneNumber",
                    Width = 257,
                    Visible = true
                }
            };

            controlDataTable.LoadColumns(dataTableColumnConfigs);
        }
    }
}