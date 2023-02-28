namespace EmployeeAccountingView
{
    partial class FormAddEmployee
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
            this.controlInputRegexPhoneNumber1 = new ControlsLibraryNet60.Input.ControlInputRegexPhoneNumber();
            this.SuspendLayout();
            // 
            // controlInputRegexPhoneNumber1
            // 
            this.controlInputRegexPhoneNumber1.Location = new System.Drawing.Point(63, 108);
            this.controlInputRegexPhoneNumber1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.controlInputRegexPhoneNumber1.Name = "controlInputRegexPhoneNumber1";
            this.controlInputRegexPhoneNumber1.Pattern = "^((\\+7|8)+\\(\\d{4}\\))?\\d{0,2}-\\d{0,2}-\\d{0,2}$";
            this.controlInputRegexPhoneNumber1.Size = new System.Drawing.Size(350, 23);
            this.controlInputRegexPhoneNumber1.TabIndex = 0;
            this.controlInputRegexPhoneNumber1.Value = "";
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlInputRegexPhoneNumber1);
            this.Name = "FormAddEmployee";
            this.Text = "FormAddEmployee";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsLibraryNet60.Input.ControlInputRegexPhoneNumber controlInputRegexPhoneNumber1;
    }
}