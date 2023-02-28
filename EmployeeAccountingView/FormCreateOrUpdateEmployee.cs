using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.BusinessLogic;

namespace EmployeeAccountingView
{
    public partial class FormCreateOrUpdateEmployee : Form
    {
        EmployeeLogic _employeeLogic;
        SkillLogic _skillLogic;
        public FormCreateOrUpdateEmployee(EmployeeLogic employeeLogic, SkillLogic skillLogic)
        {
            InitializeComponent();
            _employeeLogic = employeeLogic;
            _skillLogic = skillLogic;
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            skillsListBox.Items.AddRange(_skillLogic.Read(null).Select(skill => skill.Name).ToArray());
        }

        private void clearPhotoButton_Click(object sender, EventArgs e)
        {
            photoPictureBox.Image = null;
        }

        private void browsePhotoButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog() { Filter = "Файлы изображений|*.bmp;*.png;*.jpg"})
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    photoPictureBox.Image = Image.FromFile(dialog.FileName);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
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
                Fullname = fullnameTextBox.Text,
                SkillName = skillsListBox.SelectedElement,
                Photo = ImageToByteArray(photoPictureBox.Image),
                PhoneNumber = phoneNumberTextBox.Value
            });

            MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private static byte[] ImageToByteArray(Image image)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[]) converter.ConvertTo(image, typeof(byte[]));
        }

        

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
