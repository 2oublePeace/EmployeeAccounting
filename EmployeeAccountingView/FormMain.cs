using ControlsLibraryNet60.Models;
using DocumentFormat.OpenXml.Validation;
using EmployeeAccountingBusinessLogic.BusinessLogic;
using Ninject;

namespace EmployeeAccountingView
{
    public partial class FormMain : Form
    {
        private readonly StandardKernel _kernel;
        private readonly EmployeeLogic _employeeLogic;
        public FormMain(EmployeeLogic employeeLogic)
        {
            InitializeComponent();
            _employeeLogic = employeeLogic;
            _kernel = new StandardKernel(new Bindings());
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

            employeeDataTable.LoadColumns(dataTableColumnConfigs);
        }

        private void createEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var form = _kernel.Get<FormAddEmployee>();
           form.ShowDialog();
        }
    }
}