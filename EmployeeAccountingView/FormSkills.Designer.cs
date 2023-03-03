namespace EmployeeAccountingView
{
    partial class FormSkills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            skillDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)skillDataGridView).BeginInit();
            SuspendLayout();
            // 
            // skillDataGridView
            // 
            skillDataGridView.AllowUserToAddRows = false;
            skillDataGridView.AllowUserToDeleteRows = false;
            skillDataGridView.BackgroundColor = SystemColors.Window;
            skillDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            skillDataGridView.Dock = DockStyle.Fill;
            skillDataGridView.Location = new Point(10, 10);
            skillDataGridView.Name = "skillDataGridView";
            skillDataGridView.RowTemplate.Height = 25;
            skillDataGridView.Size = new Size(780, 430);
            skillDataGridView.TabIndex = 0;
            skillDataGridView.CellEndEdit += SkillDataGridView_CellEndEdit;
            // 
            // FormSkills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(skillDataGridView);
            Name = "FormSkills";
            Padding = new Padding(10);
            Text = "FormSkills";
            Load += FormSkills_Load;
            ((System.ComponentModel.ISupportInitialize)skillDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView skillDataGridView;
    }
}