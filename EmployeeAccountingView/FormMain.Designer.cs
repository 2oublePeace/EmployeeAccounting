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
            this.создатьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьДокументСТаблицойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьДокументСДиграммойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.создатьСотрудникаToolStripMenuItem,
            this.редактироватьСотрудникаToolStripMenuItem,
            this.удалитьСотрудникаToolStripMenuItem,
            this.создатьДокументToolStripMenuItem,
            this.создатьДокументСТаблицойToolStripMenuItem,
            this.создатьДокументСДиграммойToolStripMenuItem});
            this.controlDataTableMenuStrip.Name = "controlDataTableMenuStrip";
            this.controlDataTableMenuStrip.Size = new System.Drawing.Size(248, 158);
            // 
            // создатьСотрудникаToolStripMenuItem
            // 
            this.создатьСотрудникаToolStripMenuItem.Name = "создатьСотрудникаToolStripMenuItem";
            this.создатьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.создатьСотрудникаToolStripMenuItem.Text = "Создать сотрудника";
            this.создатьСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.создатьСотрудникаToolStripMenuItem_Click);
            // 
            // редактироватьСотрудникаToolStripMenuItem
            // 
            this.редактироватьСотрудникаToolStripMenuItem.Name = "редактироватьСотрудникаToolStripMenuItem";
            this.редактироватьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.редактироватьСотрудникаToolStripMenuItem.Text = "Редактировать сотрудника";
            // 
            // удалитьСотрудникаToolStripMenuItem
            // 
            this.удалитьСотрудникаToolStripMenuItem.Name = "удалитьСотрудникаToolStripMenuItem";
            this.удалитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.удалитьСотрудникаToolStripMenuItem.Text = "Удалить сотрудника";
            // 
            // создатьДокументToolStripMenuItem
            // 
            this.создатьДокументToolStripMenuItem.Name = "создатьДокументToolStripMenuItem";
            this.создатьДокументToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.создатьДокументToolStripMenuItem.Text = "Создать документ";
            // 
            // создатьДокументСТаблицойToolStripMenuItem
            // 
            this.создатьДокументСТаблицойToolStripMenuItem.Name = "создатьДокументСТаблицойToolStripMenuItem";
            this.создатьДокументСТаблицойToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.создатьДокументСТаблицойToolStripMenuItem.Text = "Создать документ с таблицей";
            // 
            // создатьДокументСДиграммойToolStripMenuItem
            // 
            this.создатьДокументСДиграммойToolStripMenuItem.Name = "создатьДокументСДиграммойToolStripMenuItem";
            this.создатьДокументСДиграммойToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.создатьДокументСДиграммойToolStripMenuItem.Text = "Создать документ с диграммой";
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
        private ToolStripMenuItem создатьСотрудникаToolStripMenuItem;
        private ToolStripMenuItem редактироватьСотрудникаToolStripMenuItem;
        private ToolStripMenuItem удалитьСотрудникаToolStripMenuItem;
        private ToolStripMenuItem создатьДокументToolStripMenuItem;
        private ToolStripMenuItem создатьДокументСТаблицойToolStripMenuItem;
        private ToolStripMenuItem создатьДокументСДиграммойToolStripMenuItem;
    }
}