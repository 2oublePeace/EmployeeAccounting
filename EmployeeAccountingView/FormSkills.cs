using ControlsLibraryNet60.Core;
using System.Reflection;
using TextBox = System.Windows.Forms.TextBox;

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
            skillDataGridView.Columns[2].Visible = false;
            skillDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void InsertEmptyRow()
        {
            var skills = (BindingList<SkillViewModel>)skillDataGridView.DataSource;
            skills.Add(new SkillViewModel());
            skillDataGridView.DataSource = new BindingList<SkillViewModel>(skills);
        }

        
    }
}
