using ComponentsLibraryNet60.DocumentWithTable;
using ComponentsLibraryNet60.Models;
using ControlsLibraryNet60.Models;
using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.BusinessLogic;
using EmployeeAccountingBusinessLogic.ViewModels;
using EmployeeAccountingView.Utils;
using Ninject;

namespace EmployeeAccountingView
{
    public partial class FormMain : Form
    {
        private readonly StandardKernel _kernel;
        private readonly EmployeeLogic _employeeLogic;
        private readonly SkillLogic _skillLogic;
        public FormMain(EmployeeLogic employeeLogic, SkillLogic skillLogic)
        {
            InitializeComponent();
            _employeeLogic = employeeLogic;
            _skillLogic = skillLogic;
            _kernel = new StandardKernel(new Bindings());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            InitializeTable();
            LoadData();
        }

        private void CreateEmployeeToolStripMenuItem_Click(object sender, EventArgs e) => CreateEmployee();
        private void EditEmployeeToolStripMenuItem_Click(object sender, EventArgs e) => UpdateEmployee();
        private void DeleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e) => DeleteEmployee();
        private void CreateDocumentToolStripMenuItem_Click(object sender, EventArgs e) => CreateDocument();
        private void CreateTableToolStripMenuItem_Click(object sender, EventArgs e) => CreateTable();
        private void CreateDiagramToolStripMenuItem_Click(object sender, EventArgs e) => CreateDiagram();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.A:
                    CreateEmployee();
                    return true;
                case Keys.Control | Keys.U:
                    UpdateEmployee();
                    return true;
                case Keys.Control | Keys.D:
                    DeleteEmployee();
                    return true;
                case Keys.Control | Keys.S:
                    CreateDocument();
                    return true;
                case Keys.Control | Keys.T:
                    CreateTable();
                    return true;
                case Keys.Control | Keys.C:
                    CreateDiagram();
                    return true;
                case Keys.Control | Keys.O:
                    OpenSkills();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void InitializeTable()
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
                    PropertyName = "SkillName",
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

        private void LoadData()
        {
            employeeDataTable.Clear();
            employeeDataTable.AddTable(_employeeLogic.Read(null));
        }

        private void CreateEmployee()
        {
            var form = _kernel.Get<FormCreateOrUpdateEmployee>();
            form.ShowDialog();
            LoadData();
        }

        private void UpdateEmployee()
        {
            var form = _kernel.Get<FormCreateOrUpdateEmployee>();
            form.EmployeeId = employeeDataTable.GetSelectedObject<EmployeeViewModel>().Id;
            form.ShowDialog();
            LoadData();
        }

        private void DeleteEmployee()
        {
            var dialogResult = MessageBox.Show(
                "�������� ����������. ����������?",
                "��������������",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.OK)
            {
                _employeeLogic.Delete(new EmployeeBindingModel { Id = employeeDataTable.GetSelectedObject<EmployeeViewModel>().Id });
                LoadData();
            }
        }

        private void CreateDocument()
        {
            List<byte[]> images = new();

            using (var dialog = new OpenFileDialog() { Filter = "����� �����������|*.bmp;*.png;*.jpg", Multiselect = true })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    images.AddRange(
                        dialog.FileNames
                        .Select(image => File.ReadAllBytes(image))
                        .Concat(_employeeLogic.Read(null)
                            .Select(employee => employee.Photo)));
                }
            }

            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    componentDocumentWithContextImageWord.CreateDoc(new ComponentDocumentWithContextImageConfig
                    {
                        FilePath = dialog.FileName,
                        Header = "�����������",
                        Images = images
                    });
                    MessageBox.Show("�������� ������ �������!", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateTable()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    componentDocumentWithTableHeaderRowPdf.CreateDoc(new ComponentDocumentWithTableHeaderDataConfig<EmployeeViewModel>
                    {
                        FilePath = dialog.FileName,
                        Header = "����������",
                        UseUnion = true,
                        ColumnsRowsWidth = new List<(int, int)> { (7, 0), (20, 0), (20, 0), (20, 0) },
                        ColumnUnion = new List<(int StartIndex, int Count)> { (2, 2) },
                        Headers = new List<(int ColumnIndex, int RowIndex, string Header, string PropertyName)>
                        {
                            (0, 0, "�����.", "Id"),
                            (1, 0, "���", "Fullname"),
                            (2, 0, "������", ""),
                            (2, 1, "����� ��������", "PhoneNumber"),
                            (3, 1, "�����", "SkillName"),
                        },
                        Data = _employeeLogic.Read(null)
                    });
                    MessageBox.Show("�������� ������ �������!", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateDiagram()
        {
            using (var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    componentDocumentWithChartBarExcel.CreateDoc(new ComponentDocumentWithChartConfig
                    {
                        FilePath = dialog.FileName,
                        Header = "������ �����������",
                        ChartTitle = "����������� �������",
                        LegendLocation = ComponentsLibraryNet60.Models.Location.Bottom,
                        Data = new Dictionary<string, List<(int Date, double Value)>>
                        {
                            {
                                "����� 1",
                                _skillLogic
                                .Read(null)
                                .Select(skill => (
                                    (int)skill.Id,
                                    (double)_employeeLogic.Read(null).Count(employee => skill.Name == employee.SkillName)))
                                .ToList()
                            }
                        }
                    });
                    MessageBox.Show("�������� ������ �������!", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenSkills()
        {
            var form = _kernel.Get<FormSkills>();
            form.ShowDialog();
        }
    }
}