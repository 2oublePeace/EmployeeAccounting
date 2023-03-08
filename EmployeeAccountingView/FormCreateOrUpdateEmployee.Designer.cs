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
            clearPhotoButton = new Button();
            browsePhotoButton = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            flowLayoutPanelImage = new FlowLayoutPanel();
            dataGroupBox = new GroupBox();
            skillsListBox = new ControlsLibraryNet60.Selected.ControlSelectedListBoxProperty();
            phoneNumberTextBox = new ControlsLibraryNet60.Input.ControlInputRegexPhoneNumber();
            phoneNumberLabel = new Label();
            fullnameTextBox = new TextBox();
            skillsLabel = new Label();
            fullnameLabel = new Label();
            imageGroupBox = new GroupBox();
            photoPictureBox = new PictureBox();
            flowLayoutPanelData = new FlowLayoutPanel();
            cancelButton = new Button();
            saveButton = new Button();
            tableLayoutPanel.SuspendLayout();
            flowLayoutPanelImage.SuspendLayout();
            dataGroupBox.SuspendLayout();
            imageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)photoPictureBox).BeginInit();
            flowLayoutPanelData.SuspendLayout();
            SuspendLayout();
            // 
            // clearPhotoButton
            // 
            clearPhotoButton.Location = new Point(28, 3);
            clearPhotoButton.Name = "clearPhotoButton";
            clearPhotoButton.Size = new Size(75, 23);
            clearPhotoButton.TabIndex = 13;
            clearPhotoButton.Text = "Очистить";
            clearPhotoButton.UseVisualStyleBackColor = true;
            clearPhotoButton.Click += ClearPhotoButton_Click;
            // 
            // browsePhotoButton
            // 
            browsePhotoButton.Location = new Point(109, 3);
            browsePhotoButton.Name = "browsePhotoButton";
            browsePhotoButton.Size = new Size(75, 23);
            browsePhotoButton.TabIndex = 12;
            browsePhotoButton.Text = "Обзор";
            browsePhotoButton.UseVisualStyleBackColor = true;
            browsePhotoButton.Click += BrowsePhotoButton_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(flowLayoutPanelImage, 0, 1);
            tableLayoutPanel.Controls.Add(dataGroupBox, 1, 0);
            tableLayoutPanel.Controls.Add(imageGroupBox, 0, 0);
            tableLayoutPanel.Controls.Add(flowLayoutPanelData, 0, 2);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(10, 10);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 78.47175F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7641258F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7641258F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(387, 328);
            tableLayoutPanel.TabIndex = 11;
            // 
            // flowLayoutPanelImage
            // 
            flowLayoutPanelImage.BackColor = SystemColors.Control;
            flowLayoutPanelImage.Controls.Add(browsePhotoButton);
            flowLayoutPanelImage.Controls.Add(clearPhotoButton);
            flowLayoutPanelImage.Dock = DockStyle.Fill;
            flowLayoutPanelImage.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelImage.ForeColor = SystemColors.ControlText;
            flowLayoutPanelImage.Location = new Point(3, 260);
            flowLayoutPanelImage.Name = "flowLayoutPanelImage";
            flowLayoutPanelImage.Size = new Size(187, 29);
            flowLayoutPanelImage.TabIndex = 12;
            // 
            // dataGroupBox
            // 
            dataGroupBox.Controls.Add(skillsListBox);
            dataGroupBox.Controls.Add(phoneNumberTextBox);
            dataGroupBox.Controls.Add(phoneNumberLabel);
            dataGroupBox.Controls.Add(fullnameTextBox);
            dataGroupBox.Controls.Add(skillsLabel);
            dataGroupBox.Controls.Add(fullnameLabel);
            dataGroupBox.Dock = DockStyle.Fill;
            dataGroupBox.Location = new Point(196, 3);
            dataGroupBox.Name = "dataGroupBox";
            tableLayoutPanel.SetRowSpan(dataGroupBox, 2);
            dataGroupBox.Size = new Size(188, 286);
            dataGroupBox.TabIndex = 10;
            dataGroupBox.TabStop = false;
            dataGroupBox.Text = "Данные";
            // 
            // skillsListBox
            // 
            skillsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            skillsListBox.Location = new Point(6, 81);
            skillsListBox.Margin = new Padding(4, 3, 4, 3);
            skillsListBox.Name = "skillsListBox";
            skillsListBox.SelectedElement = "";
            skillsListBox.Size = new Size(175, 155);
            skillsListBox.TabIndex = 1;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberTextBox.Location = new Point(6, 257);
            phoneNumberTextBox.Margin = new Padding(5, 3, 5, 3);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Pattern = "^((\\+7|8)+\\-\\d{3})?\\d{0,2}-\\d{0,2}-\\d{0,2}$";
            phoneNumberTextBox.Size = new Size(176, 23);
            phoneNumberTextBox.TabIndex = 0;
            phoneNumberTextBox.Value = "";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(6, 239);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(101, 15);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "Номер телефона";
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fullnameTextBox.Location = new Point(6, 37);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(176, 23);
            fullnameTextBox.TabIndex = 2;
            // 
            // skillsLabel
            // 
            skillsLabel.AutoSize = true;
            skillsLabel.Location = new Point(6, 63);
            skillsLabel.Name = "skillsLabel";
            skillsLabel.Size = new Size(50, 15);
            skillsLabel.TabIndex = 4;
            skillsLabel.Text = "Навыки";
            // 
            // fullnameLabel
            // 
            fullnameLabel.AutoSize = true;
            fullnameLabel.Location = new Point(6, 19);
            fullnameLabel.Name = "fullnameLabel";
            fullnameLabel.Size = new Size(34, 15);
            fullnameLabel.TabIndex = 3;
            fullnameLabel.Text = "ФИО";
            // 
            // imageGroupBox
            // 
            imageGroupBox.Controls.Add(photoPictureBox);
            imageGroupBox.Dock = DockStyle.Fill;
            imageGroupBox.Location = new Point(3, 3);
            imageGroupBox.Name = "imageGroupBox";
            imageGroupBox.Padding = new Padding(10);
            imageGroupBox.Size = new Size(187, 251);
            imageGroupBox.TabIndex = 9;
            imageGroupBox.TabStop = false;
            imageGroupBox.Text = "Фото";
            // 
            // photoPictureBox
            // 
            photoPictureBox.Dock = DockStyle.Fill;
            photoPictureBox.Location = new Point(10, 26);
            photoPictureBox.Name = "photoPictureBox";
            photoPictureBox.Size = new Size(167, 215);
            photoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            photoPictureBox.TabIndex = 0;
            photoPictureBox.TabStop = false;
            // 
            // flowLayoutPanelData
            // 
            tableLayoutPanel.SetColumnSpan(flowLayoutPanelData, 2);
            flowLayoutPanelData.Controls.Add(cancelButton);
            flowLayoutPanelData.Controls.Add(saveButton);
            flowLayoutPanelData.Dock = DockStyle.Fill;
            flowLayoutPanelData.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelData.Location = new Point(3, 295);
            flowLayoutPanelData.Name = "flowLayoutPanelData";
            flowLayoutPanelData.Size = new Size(381, 30);
            flowLayoutPanelData.TabIndex = 6;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(303, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(222, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 11;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // FormCreateOrUpdateEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 348);
            Controls.Add(tableLayoutPanel);
            Name = "FormCreateOrUpdateEmployee";
            Padding = new Padding(10);
            Text = "Сотрудник";
            Load += FormAddEmployee_Load;
            tableLayoutPanel.ResumeLayout(false);
            flowLayoutPanelImage.ResumeLayout(false);
            dataGroupBox.ResumeLayout(false);
            dataGroupBox.PerformLayout();
            imageGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)photoPictureBox).EndInit();
            flowLayoutPanelData.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button clearPhotoButton;
        private Button browsePhotoButton;
        private TableLayoutPanel tableLayoutPanel;
        private FlowLayoutPanel flowLayoutPanelData;
        private Button cancelButton;
        private Button saveButton;
        private GroupBox dataGroupBox;
        private ControlsLibraryNet60.Selected.ControlSelectedListBoxProperty skillsListBox;
        private ControlsLibraryNet60.Input.ControlInputRegexPhoneNumber phoneNumberTextBox;
        private Label phoneNumberLabel;
        private TextBox fullnameTextBox;
        private Label skillsLabel;
        private Label fullnameLabel;
        private GroupBox imageGroupBox;
        private FlowLayoutPanel flowLayoutPanelImage;
        private PictureBox photoPictureBox;
    }
}