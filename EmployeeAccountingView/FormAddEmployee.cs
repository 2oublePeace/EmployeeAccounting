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
    }
}
