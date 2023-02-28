namespace EmployeeAccountingView
{
    partial class FormCreateOrUpdateEmployee
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
            this.imageGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.imageGroupBox.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(6, 284);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Pattern = "^((\\+7|8)+\\-\\d{3})?\\d{0,2}-\\d{0,2}-\\d{0,2}$";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(352, 23);
            this.phoneNumberTextBox.TabIndex = 0;
            this.phoneNumberTextBox.Value = "";
            // 
            // skillsListBox
            // 
            this.skillsListBox.Location = new System.Drawing.Point(6, 90);
            this.skillsListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skillsListBox.Name = "skillsListBox";
            this.skillsListBox.SelectedElement = "";
            this.skillsListBox.Size = new System.Drawing.Size(352, 173);
            this.skillsListBox.TabIndex = 1;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Location = new System.Drawing.Point(6, 46);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(353, 23);
            this.fullnameTextBox.TabIndex = 2;
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Location = new System.Drawing.Point(6, 28);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(34, 15);
            this.fullnameLabel.TabIndex = 3;
            this.fullnameLabel.Text = "ФИО";
            // 
            // skillsLabel
            // 
            this.skillsLabel.AutoSize = true;
            this.skillsLabel.Location = new System.Drawing.Point(6, 72);
            this.skillsLabel.Name = "skillsLabel";
            this.skillsLabel.Size = new System.Drawing.Size(50, 15);
            this.skillsLabel.TabIndex = 4;
            this.skillsLabel.Text = "Навыки";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(6, 266);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(101, 15);
            this.phoneNumberLabel.TabIndex = 5;
            this.phoneNumberLabel.Text = "Номер телефона";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Location = new System.Drawing.Point(6, 22);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(288, 215);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 6;
            this.photoPictureBox.TabStop = false;
            // 
            // clearPhotoButton
            // 
            this.clearPhotoButton.Location = new System.Drawing.Point(170, 255);
            this.clearPhotoButton.Name = "clearPhotoButton";
            this.clearPhotoButton.Size = new System.Drawing.Size(87, 30);
            this.clearPhotoButton.TabIndex = 7;
            this.clearPhotoButton.Text = " Очистить";
            this.clearPhotoButton.UseVisualStyleBackColor = true;
            this.clearPhotoButton.Click += new System.EventHandler(this.clearPhotoButton_Click);
            // 
            // browsePhotoButton
            // 
            this.browsePhotoButton.Location = new System.Drawing.Point(43, 255);
            this.browsePhotoButton.Name = "browsePhotoButton";
            this.browsePhotoButton.Size = new System.Drawing.Size(87, 30);
            this.browsePhotoButton.TabIndex = 8;
            this.browsePhotoButton.Text = "Обзор";
            this.browsePhotoButton.UseVisualStyleBackColor = true;
            this.browsePhotoButton.Click += new System.EventHandler(this.browsePhotoButton_Click);
            // 
            // imageGroupBox
            // 
            this.imageGroupBox.Controls.Add(this.photoPictureBox);
            this.imageGroupBox.Controls.Add(this.browsePhotoButton);
            this.imageGroupBox.Controls.Add(this.clearPhotoButton);
            this.imageGroupBox.Location = new System.Drawing.Point(12, 12);
            this.imageGroupBox.Name = "imageGroupBox";
            this.imageGroupBox.Size = new System.Drawing.Size(300, 314);
            this.imageGroupBox.TabIndex = 9;
            this.imageGroupBox.TabStop = false;
            this.imageGroupBox.Text = "Фото";
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.skillsListBox);
            this.dataGroupBox.Controls.Add(this.phoneNumberTextBox);
            this.dataGroupBox.Controls.Add(this.phoneNumberLabel);
            this.dataGroupBox.Controls.Add(this.fullnameTextBox);
            this.dataGroupBox.Controls.Add(this.skillsLabel);
            this.dataGroupBox.Controls.Add(this.fullnameLabel);
            this.dataGroupBox.Location = new System.Drawing.Point(318, 12);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(364, 314);
            this.dataGroupBox.TabIndex = 10;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Данные";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(526, 332);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(607, 332);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 364);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.imageGroupBox);
            this.Name = "FormAddEmployee";
            this.Text = "Создание сотрудника";
            this.Load += new System.EventHandler(this.FormAddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.imageGroupBox.ResumeLayout(false);
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            this.ResumeLayout(false);

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
        private GroupBox imageGroupBox;
        private GroupBox dataGroupBox;
        private Button saveButton;
        private Button cancelButton;
    }
}