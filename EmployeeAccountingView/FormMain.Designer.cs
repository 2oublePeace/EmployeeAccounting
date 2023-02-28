namespace EmployeeAccountingView
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.employeeDataTable = new ControlsLibraryNet60.Data.ControlDataTableTable();
            this.controlDataTableMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDataTableMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeDataTable
            // 
            this.employeeDataTable.ContextMenuStrip = this.controlDataTableMenuStrip;
            this.employeeDataTable.Location = new System.Drawing.Point(13, 12);
            this.employeeDataTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.employeeDataTable.Name = "employeeDataTable";
            this.employeeDataTable.SelectedRowIndex = -1;
            this.employeeDataTable.Size = new System.Drawing.Size(774, 426);
            this.employeeDataTable.TabIndex = 0;
            // 
            // controlDataTableMenuStrip
            // 
            this.controlDataTableMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEmployeeToolStripMenuItem,
            this.editEmployeeToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem,
            this.createDocumentToolStripMenuItem,
            this.createTableToolStripMenuItem,
            this.createDiagramToolStripMenuItem});
            this.controlDataTableMenuStrip.Name = "controlDataTableMenuStrip";
            this.controlDataTableMenuStrip.Size = new System.Drawing.Size(221, 136);
            // 
            // createEmployeeToolStripMenuItem
            // 
            this.createEmployeeToolStripMenuItem.Name = "createEmployeeToolStripMenuItem";
            this.createEmployeeToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.createEmployeeToolStripMenuItem.Text = "Создать сотрудника";
            this.createEmployeeToolStripMenuItem.Click += new System.EventHandler(this.createEmployeeToolStripMenuItem_Click);
            // 
            // editEmployeeToolStripMenuItem
            // 
            this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
            this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.editEmployeeToolStripMenuItem.Text = "Редактировать сотрудника";
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.deleteEmployeeToolStripMenuItem.Text = "Удалить сотрудника";
            // 
            // createDocumentToolStripMenuItem
            // 
            this.createDocumentToolStripMenuItem.Name = "createDocumentToolStripMenuItem";
            this.createDocumentToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.createDocumentToolStripMenuItem.Text = "Создать документ";
            // 
            // createTableToolStripMenuItem
            // 
            this.createTableToolStripMenuItem.Name = "createTableToolStripMenuItem";
            this.createTableToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.createTableToolStripMenuItem.Text = "Создать таблицу";
            // 
            // createDiagramToolStripMenuItem
            // 
            this.createDiagramToolStripMenuItem.Name = "createDiagramToolStripMenuItem";
            this.createDiagramToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.createDiagramToolStripMenuItem.Text = "Создать диграмму";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeeDataTable);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.controlDataTableMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsLibraryNet60.Data.ControlDataTableTable employeeDataTable;
        private ContextMenuStrip controlDataTableMenuStrip;
        private ToolStripMenuItem createEmployeeToolStripMenuItem;
        private ToolStripMenuItem editEmployeeToolStripMenuItem;
        private ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private ToolStripMenuItem createDocumentToolStripMenuItem;
        private ToolStripMenuItem createTableToolStripMenuItem;
        private ToolStripMenuItem createDiagramToolStripMenuItem;
    }
}