using ControlsLibraryNet60.Core;
using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.BusinessLogic;
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
            using (var dialog = new OpenFileDialog() { Filter = "Файлы изображений|*.bmp;*.png;*.jpg" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    photoPictureBox.Image = Image.FromFile(dialog.FileName);
                }
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
            skillsListBox.Items.AddRange(_skillLogic.Read(null).Select(skill => skill.Name).ToArray());
            if (EmployeeId != null)
            {
                var employee = _employeeLogic.Read(new EmployeeBindingModel { Id = EmployeeId }).FirstOrDefault();
                if (employee != null)
                {
                    fullnameTextBox.Text = employee.Fullname;
                    LoadPhoneNumberTextBox(phoneNumberTextBox, employee.PhoneNumber);
                    skillsListBox.SelectedElement = employee.Skill.ToString();
                    photoPictureBox.Image = ByteArrayConverter.ByteArrayToImage(employee.Photo);
                }
            }
        }
        
        private void LoadPhoneNumberTextBox(ControlInputRegex controlInputRegex, string phoneNumber)
        {
            Type type = typeof(ControlInputRegex);
            FieldInfo fieldInfo = type.GetField("textBoxInput", BindingFlags.Instance | BindingFlags.NonPublic);
            TextBox textBox = (TextBox)fieldInfo.GetValue(controlInputRegex);
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
                var employee = _employeeLogic.Read(new EmployeeBindingModel { Id = employeeId }).FirstOrDefault();
                if (fullnameTextBox.Text != employee.Fullname ||
                    skillsListBox.SelectedElement != employee.Skill.ToString() ||
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
