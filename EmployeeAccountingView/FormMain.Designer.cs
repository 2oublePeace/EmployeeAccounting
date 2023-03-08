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
            components = new System.ComponentModel.Container();
            employeeDataTable = new ControlsLibraryNet60.Data.ControlDataTableTable();
            controlDataTableMenuStrip = new ContextMenuStrip(components);
            createEmployeeToolStripMenuItem = new ToolStripMenuItem();
            editEmployeeToolStripMenuItem = new ToolStripMenuItem();
            deleteEmployeeToolStripMenuItem = new ToolStripMenuItem();
            createDocumentToolStripMenuItem = new ToolStripMenuItem();
            createTableToolStripMenuItem = new ToolStripMenuItem();
            createDiagramToolStripMenuItem = new ToolStripMenuItem();
            componentDocumentWithContextImageWord = new ComponentsLibraryNet60.DocumentWithContext.ComponentDocumentWithContextImageWord(components);
            componentDocumentWithTableHeaderRowPdf = new ComponentsLibraryNet60.DocumentWithTable.ComponentDocumentWithTableHeaderRowPdf(components);
            componentDocumentWithChartBarExcel = new ComponentsLibraryNet60.DocumentWithChart.ComponentDocumentWithChartBarExcel(components);
            skillsToolStripMenuItem = new ToolStripMenuItem();
            controlDataTableMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // employeeDataTable
            // 
            employeeDataTable.ContextMenuStrip = controlDataTableMenuStrip;
            employeeDataTable.Dock = DockStyle.Fill;
            employeeDataTable.Location = new Point(10, 10);
            employeeDataTable.Margin = new Padding(4, 3, 4, 3);
            employeeDataTable.Name = "employeeDataTable";
            employeeDataTable.SelectedRowIndex = -1;
            employeeDataTable.Size = new Size(780, 430);
            employeeDataTable.TabIndex = 0;
            // 
            // controlDataTableMenuStrip
            // 
            controlDataTableMenuStrip.Items.AddRange(new ToolStripItem[] { createEmployeeToolStripMenuItem, editEmployeeToolStripMenuItem, deleteEmployeeToolStripMenuItem, createDocumentToolStripMenuItem, createTableToolStripMenuItem, createDiagramToolStripMenuItem, skillsToolStripMenuItem });
            controlDataTableMenuStrip.Name = "controlDataTableMenuStrip";
            controlDataTableMenuStrip.Size = new Size(221, 180);
            // 
            // createEmployeeToolStripMenuItem
            // 
            createEmployeeToolStripMenuItem.Name = "createEmployeeToolStripMenuItem";
            createEmployeeToolStripMenuItem.Size = new Size(220, 22);
            createEmployeeToolStripMenuItem.Text = "Создать сотрудника";
            createEmployeeToolStripMenuItem.Click += CreateEmployeeToolStripMenuItem_Click;
            // 
            // editEmployeeToolStripMenuItem
            // 
            editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
            editEmployeeToolStripMenuItem.Size = new Size(220, 22);
            editEmployeeToolStripMenuItem.Text = "Редактировать сотрудника";
            editEmployeeToolStripMenuItem.Click += EditEmployeeToolStripMenuItem_Click;
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            deleteEmployeeToolStripMenuItem.Size = new Size(220, 22);
            deleteEmployeeToolStripMenuItem.Text = "Удалить сотрудника";
            deleteEmployeeToolStripMenuItem.Click += DeleteEmployeeToolStripMenuItem_Click;
            // 
            // createDocumentToolStripMenuItem
            // 
            createDocumentToolStripMenuItem.Name = "createDocumentToolStripMenuItem";
            createDocumentToolStripMenuItem.Size = new Size(220, 22);
            createDocumentToolStripMenuItem.Text = "Создать документ";
            createDocumentToolStripMenuItem.Click += CreateDocumentToolStripMenuItem_Click;
            // 
            // createTableToolStripMenuItem
            // 
            createTableToolStripMenuItem.Name = "createTableToolStripMenuItem";
            createTableToolStripMenuItem.Size = new Size(220, 22);
            createTableToolStripMenuItem.Text = "Создать таблицу";
            createTableToolStripMenuItem.Click += CreateTableToolStripMenuItem_Click;
            // 
            // createDiagramToolStripMenuItem
            // 
            createDiagramToolStripMenuItem.Name = "createDiagramToolStripMenuItem";
            createDiagramToolStripMenuItem.Size = new Size(220, 22);
            createDiagramToolStripMenuItem.Text = "Создать диграмму";
            createDiagramToolStripMenuItem.Click += CreateDiagramToolStripMenuItem_Click;
            // 
            // skillsToolStripMenuItem
            // 
            skillsToolStripMenuItem.Name = "skillsToolStripMenuItem";
            skillsToolStripMenuItem.Size = new Size(220, 22);
            skillsToolStripMenuItem.Text = "Навыки";
            skillsToolStripMenuItem.Click += SkillsToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(employeeDataTable);
            Name = "FormMain";
            Padding = new Padding(10);
            Text = "Список сотрудников";
            Load += FormMain_Load;
            controlDataTableMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
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
        private ComponentsLibraryNet60.DocumentWithContext.ComponentDocumentWithContextImageWord componentDocumentWithContextImageWord;
        private ComponentsLibraryNet60.DocumentWithTable.ComponentDocumentWithTableHeaderRowPdf componentDocumentWithTableHeaderRowPdf;
        private ComponentsLibraryNet60.DocumentWithChart.ComponentDocumentWithChartBarExcel componentDocumentWithChartBarExcel;
        private ToolStripMenuItem skillsToolStripMenuItem;
    }
}