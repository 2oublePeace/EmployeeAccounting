using ControlsLibraryNet60.Core;
using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.BusinessLogic;
using EmployeeAccountingBusinessLogic.ViewModels;
using EmployeeAccountingView.Utils;
using System.Reflection;

namespace EmployeeAccountingView
{
    public partial class FormCreateOrUpdateEmployee : Form
    {
        private readonly EmployeeLogic _employeeLogic;
        private readonly SkillLogic _skillLogic;
        public int? EmployeeId { get; set; }
        public FormCreateOrUpdateEmployee(EmployeeLogic employeeLogic, SkillLogic skillLogic)
        {
            InitializeComponent();
            _employeeLogic = employeeLogic;
            _skillLogic = skillLogic;
        }
        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void BrowsePhotoButton_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog() { Filter = "Файлы изображений|*.bmp;*.png;*.jpg" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                photoPictureBox.Image = Image.FromFile(dialog.FileName);
            }
        }
        private void ClearPhotoButton_Click(object sender, EventArgs e)
        {
            photoPictureBox.Image = null;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fullnameTextBox.Text))
            {
                MessageBox.Show("Заполните ФИО сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(skillsListBox.SelectedElement))
            {
                MessageBox.Show("Выберите навык сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(phoneNumberTextBox.Value))
            {
                MessageBox.Show("Корректно введите номер телефона сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _employeeLogic.CreateOrUpdate(new EmployeeBindingModel()
            {
                Id = EmployeeId,
                Fullname = fullnameTextBox.Text,
                SkillName = skillsListBox.SelectedElement,
                Photo = ByteArrayConverter.ImageToByteArray(photoPictureBox.Image),
                PhoneNumber = phoneNumberTextBox.Value
            });

            MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (IsElementValuesChanged(EmployeeId))
            {
                var dialogResult = MessageBox.Show(
                    "Изменения не сохранены. Продолжить?",
                    "Предупреждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void LoadData()
        {
            skillsListBox.Items.AddRange(_skillLogic
                .Read(null)
                .Select(skill => skill.Name ?? throw new Exception("Не найдено имя навыка"))
                .ToArray());

            if (EmployeeId != null)
            {
                EmployeeViewModel employee = _employeeLogic
                    .Read(new EmployeeBindingModel { 
                        Id = EmployeeId })
                    .FirstOrDefault() ??
                        throw new Exception("Не найден сотрудник");
                
                fullnameTextBox.Text = employee.Fullname;
                LoadPhoneNumberTextBox(phoneNumberTextBox, employee.PhoneNumber ?? 
                    throw new Exception("Не найден номер телефона сотрудника"));
                skillsListBox.SelectedElement = employee.SkillName ?? 
                    throw new Exception("Не найдено имя навыка");
                photoPictureBox.Image = ByteArrayConverter.ByteArrayToImage(employee.Photo ?? 
                    throw new Exception("Не найдено фото сотрудника"));
            }
        }
        private static void LoadPhoneNumberTextBox(ControlInputRegex controlInputRegex, string phoneNumber)
        {
            Type type = typeof(ControlInputRegex);
            FieldInfo fieldInfo = type.GetField("textBoxInput", BindingFlags.Instance | BindingFlags.NonPublic) ?? 
                throw new Exception("Поле не найдено");
            TextBox textBox = (TextBox?)fieldInfo.GetValue(controlInputRegex) ?? 
                throw new Exception("Текстовое поле имеет значение null");
            textBox.Text = phoneNumber;
        }
        private bool IsElementValuesChanged(int? employeeId)
        {
            if (employeeId == null)
            {
                if (!string.IsNullOrEmpty(fullnameTextBox.Text) ||
                    !string.IsNullOrEmpty(skillsListBox.SelectedElement) ||
                    !string.IsNullOrEmpty(phoneNumberTextBox.Value) ||
                    photoPictureBox.Image != null)
                {
                    return true;
                }
            }
            else
            {
                EmployeeViewModel employee = _employeeLogic
                    .Read(new EmployeeBindingModel { Id = employeeId })
                    .FirstOrDefault() ??
                        throw new Exception("Сотрудник не найден");

                if (fullnameTextBox.Text != employee.Fullname ||
                    skillsListBox.SelectedElement != employee.SkillName ||
                    phoneNumberTextBox.Value != employee.PhoneNumber ||
                    ByteArrayConverter.ImageToByteArray(photoPictureBox.Image).Equals(employee.Photo))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
