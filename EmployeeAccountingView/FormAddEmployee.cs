using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.BusinessLogic;
using EmployeeAccountingBusinessLogic.Enums;

namespace EmployeeAccountingView
{
    public partial class FormAddEmployee : Form
    {
        EmployeeLogic _employeeLogic;
        public FormAddEmployee(EmployeeLogic employeeLogic)
        {
            InitializeComponent();
            _employeeLogic = employeeLogic;
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
     
            _employeeLogic.CreateOrUpdate(new EmployeeBindingModel()
            {
                Fullname = fullnameTextBox.Text,
                SkillName = skillsListBox.SelectedElement,
                Photo = ImageToByteArray(photoPictureBox.Image),
                PhoneNumber = phoneNumberTextBox.Text
            });

            MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        public static byte[] ImageToByteArray(Image image)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(image, typeof(byte[]));
        }
    }
}
