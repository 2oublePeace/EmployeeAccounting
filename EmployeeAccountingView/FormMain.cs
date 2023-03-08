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
        private readonly EmployeeLogic _employeeLogic;
        private readonly SkillLogic _skillLogic;
        public FormMain(EmployeeLogic employeeLogic, SkillLogic skillLogic)
        {
            InitializeComponent();
            InitializeTable();
            _employeeLogic = employeeLogic;
            _skillLogic = skillLogic;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void CreateEmployeeToolStripMenuItem_Click(object sender, EventArgs e) => CreateEmployee();
        private void EditEmployeeToolStripMenuItem_Click(object sender, EventArgs e) => UpdateEmployee();
        private void DeleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e) => DeleteEmployee();
        private void CreateDocumentToolStripMenuItem_Click(object sender, EventArgs e) => CreateDocument();
        private void CreateTableToolStripMenuItem_Click(object sender, EventArgs e) => CreateTable();
        private void CreateDiagramToolStripMenuItem_Click(object sender, EventArgs e) => CreateDiagram();
        private void SkillsToolStripMenuItem_Click(object sender, EventArgs e) => OpenFormSkills();
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
                    OpenFormSkills();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void InitializeTable()
        {
            List<DataTableColumnConfig> dataTableColumnConfigs = new()
            {
                new DataTableColumnConfig()
                {
                    ColumnHeader = "Идентификатор",
                    PropertyName = "Id",
                    Width = 259,
                    Visible = false
                },
                new DataTableColumnConfig()
                {
                    ColumnHeader = "ФИО",
                    PropertyName = "Fullname",
                    Width = 259,
                    Visible = true
                },
                new DataTableColumnConfig()
                {
                    ColumnHeader = "Навык",
                    PropertyName = "SkillName",
                    Width = 259,
                    Visible = true
                },
                new DataTableColumnConfig()
                {
                    ColumnHeader = "Номер телефона",
                    PropertyName = "PhoneNumber",
                    Width = 259,
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
            FormCreateOrUpdateEmployee form = NinjectKernel.GetInstance().Get<FormCreateOrUpdateEmployee>();
            form.ShowDialog();
            LoadData();
        }
        private void UpdateEmployee()
        {
            EmployeeViewModel? selectedEmployee = employeeDataTable.GetSelectedObject<EmployeeViewModel>();
            
            if (selectedEmployee == null)
            {
                MessageBox.Show(
                    "Не был выбран сотрудник",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            FormCreateOrUpdateEmployee form = NinjectKernel.GetInstance().Get<FormCreateOrUpdateEmployee>();
            form.EmployeeId = selectedEmployee.Id;
            form.ShowDialog();
            LoadData();
        }
        private void DeleteEmployee()
        {
            var dialogResult = MessageBox.Show(
                "Удаление сотрудника. Продолжить?",
                "Предупреждение",
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

            using var openFileDialog = new OpenFileDialog() { 
                Filter = "Файлы изображений|*.bmp;*.png;*.jpg", 
                Multiselect = true 
            };
            using var saveFileDialog = new SaveFileDialog { 
                Filter = "docx|*.docx" 
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                images.AddRange(
                    openFileDialog.FileNames
                    .Select(image => File.ReadAllBytes(image))
                    .Concat(_employeeLogic
                        .Read(null).Select(employee => employee.Photo ?? throw new Exception("Фото сотрудника было не найдено"))));
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            componentDocumentWithContextImageWord.CreateDoc(new ComponentDocumentWithContextImageConfig
            {
                FilePath = saveFileDialog.FileName,
                Header = "Изображения",
                Images = images
            });
            MessageBox.Show("Создание прошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CreateTable()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                componentDocumentWithTableHeaderRowPdf.CreateDoc(new ComponentDocumentWithTableHeaderDataConfig<EmployeeViewModel>
                {
                    FilePath = dialog.FileName,
                    Header = "Сотрудники",
                    UseUnion = true,
                    ColumnsRowsWidth = new List<(int, int)> { (7, 0), (20, 0), (20, 0), (20, 0) },
                    ColumnUnion = new List<(int StartIndex, int Count)> { (2, 2) },
                    Headers = new List<(int ColumnIndex, int RowIndex, string Header, string PropertyName)>
                        {
                            (0, 0, "Идент.", "Id"),
                            (1, 0, "ФИО", "Fullname"),
                            (2, 0, "Работа", ""),
                            (2, 1, "Номер телефона", "PhoneNumber"),
                            (3, 1, "Навык", "SkillName"),
                        },
                    Data = _employeeLogic.Read(null)
                });
                MessageBox.Show("Создание прошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreateDiagram()
        {
            using var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                componentDocumentWithChartBarExcel.CreateDoc(new ComponentDocumentWithChartConfig
                {
                    FilePath = dialog.FileName,
                    Header = "Навыки сотрудников",
                    ChartTitle = "Гистограмма навыков",
                    LegendLocation = ComponentsLibraryNet60.Models.Location.Bottom,
                    Data = new Dictionary<string, List<(int Date, double Value)>>
                        {
                            {
                                "Серия 1",
                                _skillLogic
                                .Read(null)
                                .Select(skill => (
                                    skill.Id ?? throw new Exception("Id навыка имеет значение null"),
                                    (double)_employeeLogic.Read(null)
                                    .Count(employee => skill.Name == employee.SkillName)))
                                .ToList()
                            }
                        }
                });
                MessageBox.Show("Создание прошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OpenFormSkills()
        {
            var form = NinjectKernel.GetInstance().Get<FormSkills>();
            form.ShowDialog();
            LoadData();
        }
    }
}