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
            this.phoneNumberTextBox = new ControlsLibraryNet60.Input.ControlInputRegexPhoneNumber();
            this.skillsListBox = new ControlsLibraryNet60.Selected.ControlSelectedListBoxProperty();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.skillsLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.clearPhotoButton = new System.Windows.Forms.Button();
            this.browsePhotoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(12, 265);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Pattern = "^((\\+7|8)+\\(\\d{4}\\))?\\d{0,2}-\\d{0,2}-\\d{0,2}$";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(352, 23);
            this.phoneNumberTextBox.TabIndex = 0;
            this.phoneNumberTextBox.Value = "";
            // 
            // skillsListBox
            // 
            this.skillsListBox.Location = new System.Drawing.Point(12, 71);
            this.skillsListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skillsListBox.Name = "skillsListBox";
            this.skillsListBox.SelectedElement = "";
            this.skillsListBox.Size = new System.Drawing.Size(352, 173);
            this.skillsListBox.TabIndex = 1;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Location = new System.Drawing.Point(12, 27);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(353, 23);
            this.fullnameTextBox.TabIndex = 2;
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Location = new System.Drawing.Point(12, 9);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(34, 15);
            this.fullnameLabel.TabIndex = 3;
            this.fullnameLabel.Text = "ФИО";
            // 
            // skillsLabel
            // 
            this.skillsLabel.AutoSize = true;
            this.skillsLabel.Location = new System.Drawing.Point(12, 53);
            this.skillsLabel.Name = "skillsLabel";
            this.skillsLabel.Size = new System.Drawing.Size(50, 15);
            this.skillsLabel.TabIndex = 4;
            this.skillsLabel.Text = "Навыки";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(12, 247);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(101, 15);
            this.phoneNumberLabel.TabIndex = 5;
            this.phoneNumberLabel.Text = "Номер телефона";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Location = new System.Drawing.Point(381, 29);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(288, 215);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 6;
            this.photoPictureBox.TabStop = false;
            // 
            // clearPhotoButton
            // 
            this.clearPhotoButton.Location = new System.Drawing.Point(545, 262);
            this.clearPhotoButton.Name = "clearPhotoButton";
            this.clearPhotoButton.Size = new System.Drawing.Size(87, 30);
            this.clearPhotoButton.TabIndex = 7;
            this.clearPhotoButton.Text = " Очистить";
            this.clearPhotoButton.UseVisualStyleBackColor = true;
            this.clearPhotoButton.Click += new System.EventHandler(this.clearPhotoButton_Click);
            // 
            // browsePhotoButton
            // 
            this.browsePhotoButton.Location = new System.Drawing.Point(418, 262);
            this.browsePhotoButton.Name = "browsePhotoButton";
            this.browsePhotoButton.Size = new System.Drawing.Size(87, 30);
            this.browsePhotoButton.TabIndex = 8;
            this.browsePhotoButton.Text = "Обзор";
            this.browsePhotoButton.UseVisualStyleBackColor = true;
            this.browsePhotoButton.Click += new System.EventHandler(this.browsePhotoButton_Click);
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 304);
            this.Controls.Add(this.browsePhotoButton);
            this.Controls.Add(this.clearPhotoButton);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.skillsLabel);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.fullnameTextBox);
            this.Controls.Add(this.skillsListBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Name = "FormAddEmployee";
            this.Text = "FormAddEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlsLibraryNet60.Input.ControlInputRegexPhoneNumber phoneNumberTextBox;
        private ControlsLibraryNet60.Selected.ControlSelectedListBoxProperty skillsListBox;
        private TextBox fullnameTextBox;
        private Label fullnameLabel;
        private Label skillsLabel;
        private Label phoneNumberLabel;
        private PictureBox photoPictureBox;
        private Button clearPhotoButton;
        private Button browsePhotoButton;
    }
}