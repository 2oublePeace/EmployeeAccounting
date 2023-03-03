using EmployeeAccountingBusinessLogic.BindingModels;
using EmployeeAccountingBusinessLogic.BusinessLogic;
using EmployeeAccountingBusinessLogic.ViewModels;
using System.ComponentModel;

namespace EmployeeAccountingView
{
    public partial class FormSkills : Form
    {
        private readonly SkillLogic _skillLogic;
        public FormSkills(SkillLogic skillLogic)
        {
            InitializeComponent();
            _skillLogic = skillLogic;
        }

        private void FormSkills_Load(object sender, EventArgs e) => LoadData();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Insert:
                    InsertEmptyRow();
                    return true;
                case Keys.Delete:
                    DeleteSelectedRowOrSkill();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void LoadData()
        {
            skillDataGridView.DataSource = new BindingList<SkillViewModel>(_skillLogic.Read(null));
            skillDataGridView.Columns[0].Visible = false;
            skillDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void InsertEmptyRow()
        {
            var skills = (BindingList<SkillViewModel>)skillDataGridView.DataSource;
            skills.Add(new SkillViewModel());
            skillDataGridView.DataSource = new BindingList<SkillViewModel>(skills);
        }

        private void DeleteSelectedRowOrSkill()
        {
            var dialogResult = MessageBox.Show(
               "Удаление сотрудника. Продолжить?",
               "Предупреждение",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                if (skillDataGridView.CurrentRow.Cells[0].Value != null)
                {
                    _skillLogic.Delete(new SkillBindingModel { Id = (int)skillDataGridView.CurrentRow.Cells[0].Value });
                    LoadData();
                }
                else
                {
                    skillDataGridView.Rows.Remove(skillDataGridView.CurrentRow);
                }
            }
        }

        private void SkillDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty((string)skillDataGridView.CurrentRow.Cells[1].Value))
            {
                _skillLogic.CreateOrUpdate(new SkillBindingModel
                {
                    Name = (string)skillDataGridView.CurrentRow.Cells[1].Value
                });
                LoadData();
            }
        }
    }
}
