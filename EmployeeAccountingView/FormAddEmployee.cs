using EmployeeAccountingBusinessLogic.BusinessLogic;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
