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
            controlPhoneNumber = new ControlsLibraryNet60.Input.ControlInputRegexPhoneNumber();
            SuspendLayout();
            // 
            // controlPhoneNumber
            // 
            controlPhoneNumber.Location = new Point(392, 269);
            controlPhoneNumber.Margin = new Padding(5, 3, 5, 3);
            controlPhoneNumber.Name = "controlPhoneNumber";
            controlPhoneNumber.Pattern = "^(8)-(\\d{3})-(\\d{2})-(\\d{2})$";
            controlPhoneNumber.Size = new Size(350, 23);
            controlPhoneNumber.TabIndex = 0;
            controlPhoneNumber.Value = "";
            // 
            // FormSkills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(controlPhoneNumber);
            Name = "FormSkills";
            Text = "FormSkills";
            ResumeLayout(false);
        }

        #endregion

        private ControlsLibraryNet60.Input.ControlInputRegexPhoneNumber controlPhoneNumber;
    }
}