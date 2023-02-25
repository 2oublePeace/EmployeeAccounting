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
            this.controlDataTable = new ControlsLibraryNet60.Data.ControlDataTableTable();
            this.SuspendLayout();
            // 
            // controlDataTable
            // 
            this.controlDataTable.Location = new System.Drawing.Point(13, 12);
            this.controlDataTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.controlDataTable.Name = "controlDataTable";
            this.controlDataTable.SelectedRowIndex = -1;
            this.controlDataTable.Size = new System.Drawing.Size(774, 426);
            this.controlDataTable.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlDataTable);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsLibraryNet60.Data.ControlDataTableTable controlDataTable;
    }
}