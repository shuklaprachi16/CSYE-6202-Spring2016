namespace Assignment_win
{
    partial class NewStudent
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
            this.newStudentStudentIdLabel = new System.Windows.Forms.Label();
            this.newStudentFirstNameLabel = new System.Windows.Forms.Label();
            this.newStudentLastNameLabel = new System.Windows.Forms.Label();
            this.newStudentDepartmentLabel = new System.Windows.Forms.Label();
            this.newStudentStudentIdText = new System.Windows.Forms.TextBox();
            this.newStudentFirstNameText = new System.Windows.Forms.TextBox();
            this.newStudentLastNameText = new System.Windows.Forms.TextBox();
            this.newstudentEnrolmentTypePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.newStudentPartTimeRadio = new System.Windows.Forms.RadioButton();
            this.newStudentFullTimeRadio = new System.Windows.Forms.RadioButton();
            this.newStudentAddButton = new System.Windows.Forms.Button();
            this.newStudentResetButton = new System.Windows.Forms.Button();
            this.newStudentDeptComboBox = new System.Windows.Forms.ComboBox();
            this.newStudentBackButton = new System.Windows.Forms.Button();
            this.newstudentEnrolmentTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newStudentStudentIdLabel
            // 
            this.newStudentStudentIdLabel.AutoSize = true;
            this.newStudentStudentIdLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.newStudentStudentIdLabel.Location = new System.Drawing.Point(56, 24);
            this.newStudentStudentIdLabel.Margin = new System.Windows.Forms.Padding(5);
            this.newStudentStudentIdLabel.Name = "newStudentStudentIdLabel";
            this.newStudentStudentIdLabel.Padding = new System.Windows.Forms.Padding(5);
            this.newStudentStudentIdLabel.Size = new System.Drawing.Size(68, 23);
            this.newStudentStudentIdLabel.TabIndex = 0;
            this.newStudentStudentIdLabel.Text = "Student ID";
            // 
            // newStudentFirstNameLabel
            // 
            this.newStudentFirstNameLabel.AutoSize = true;
            this.newStudentFirstNameLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.newStudentFirstNameLabel.Location = new System.Drawing.Point(56, 70);
            this.newStudentFirstNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.newStudentFirstNameLabel.Name = "newStudentFirstNameLabel";
            this.newStudentFirstNameLabel.Padding = new System.Windows.Forms.Padding(5);
            this.newStudentFirstNameLabel.Size = new System.Drawing.Size(67, 23);
            this.newStudentFirstNameLabel.TabIndex = 1;
            this.newStudentFirstNameLabel.Text = "First Name";
            // 
            // newStudentLastNameLabel
            // 
            this.newStudentLastNameLabel.AutoSize = true;
            this.newStudentLastNameLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.newStudentLastNameLabel.Location = new System.Drawing.Point(56, 113);
            this.newStudentLastNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.newStudentLastNameLabel.Name = "newStudentLastNameLabel";
            this.newStudentLastNameLabel.Padding = new System.Windows.Forms.Padding(5);
            this.newStudentLastNameLabel.Size = new System.Drawing.Size(68, 23);
            this.newStudentLastNameLabel.TabIndex = 2;
            this.newStudentLastNameLabel.Text = "Last Name";
            // 
            // newStudentDepartmentLabel
            // 
            this.newStudentDepartmentLabel.AutoSize = true;
            this.newStudentDepartmentLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.newStudentDepartmentLabel.Location = new System.Drawing.Point(56, 153);
            this.newStudentDepartmentLabel.Margin = new System.Windows.Forms.Padding(5);
            this.newStudentDepartmentLabel.Name = "newStudentDepartmentLabel";
            this.newStudentDepartmentLabel.Padding = new System.Windows.Forms.Padding(5);
            this.newStudentDepartmentLabel.Size = new System.Drawing.Size(72, 23);
            this.newStudentDepartmentLabel.TabIndex = 3;
            this.newStudentDepartmentLabel.Text = "Department";
            // 
            // newStudentStudentIdText
            // 
            this.newStudentStudentIdText.Enabled = false;
            this.newStudentStudentIdText.Location = new System.Drawing.Point(244, 16);
            this.newStudentStudentIdText.Name = "newStudentStudentIdText";
            this.newStudentStudentIdText.Size = new System.Drawing.Size(121, 20);
            this.newStudentStudentIdText.TabIndex = 4;
            // 
            // newStudentFirstNameText
            // 
            this.newStudentFirstNameText.Location = new System.Drawing.Point(244, 67);
            this.newStudentFirstNameText.Name = "newStudentFirstNameText";
            this.newStudentFirstNameText.Size = new System.Drawing.Size(121, 20);
            this.newStudentFirstNameText.TabIndex = 5;
            this.newStudentFirstNameText.TextChanged += new System.EventHandler(this.newStudentFirstNameText_TextChanged);
            // 
            // newStudentLastNameText
            // 
            this.newStudentLastNameText.Location = new System.Drawing.Point(244, 113);
            this.newStudentLastNameText.Name = "newStudentLastNameText";
            this.newStudentLastNameText.Size = new System.Drawing.Size(121, 20);
            this.newStudentLastNameText.TabIndex = 6;
            this.newStudentLastNameText.TextChanged += new System.EventHandler(this.newStudentLastNameText_TextChanged);
            // 
            // newstudentEnrolmentTypePanel
            // 
            this.newstudentEnrolmentTypePanel.Controls.Add(this.label1);
            this.newstudentEnrolmentTypePanel.Controls.Add(this.newStudentPartTimeRadio);
            this.newstudentEnrolmentTypePanel.Controls.Add(this.newStudentFullTimeRadio);
            this.newstudentEnrolmentTypePanel.Location = new System.Drawing.Point(456, 24);
            this.newstudentEnrolmentTypePanel.Name = "newstudentEnrolmentTypePanel";
            this.newstudentEnrolmentTypePanel.Size = new System.Drawing.Size(282, 132);
            this.newstudentEnrolmentTypePanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enrollment Type";
            // 
            // newStudentPartTimeRadio
            // 
            this.newStudentPartTimeRadio.AutoSize = true;
            this.newStudentPartTimeRadio.Location = new System.Drawing.Point(169, 69);
            this.newStudentPartTimeRadio.Name = "newStudentPartTimeRadio";
            this.newStudentPartTimeRadio.Size = new System.Drawing.Size(70, 17);
            this.newStudentPartTimeRadio.TabIndex = 1;
            this.newStudentPartTimeRadio.TabStop = true;
            this.newStudentPartTimeRadio.Text = "Part Time";
            this.newStudentPartTimeRadio.UseVisualStyleBackColor = true;
            // 
            // newStudentFullTimeRadio
            // 
            this.newStudentFullTimeRadio.AutoSize = true;
            this.newStudentFullTimeRadio.Location = new System.Drawing.Point(20, 69);
            this.newStudentFullTimeRadio.Name = "newStudentFullTimeRadio";
            this.newStudentFullTimeRadio.Size = new System.Drawing.Size(67, 17);
            this.newStudentFullTimeRadio.TabIndex = 0;
            this.newStudentFullTimeRadio.TabStop = true;
            this.newStudentFullTimeRadio.Text = "Full Time";
            this.newStudentFullTimeRadio.UseVisualStyleBackColor = true;
            // 
            // newStudentAddButton
            // 
            this.newStudentAddButton.Enabled = false;
            this.newStudentAddButton.Location = new System.Drawing.Point(143, 261);
            this.newStudentAddButton.Name = "newStudentAddButton";
            this.newStudentAddButton.Size = new System.Drawing.Size(130, 37);
            this.newStudentAddButton.TabIndex = 8;
            this.newStudentAddButton.Text = "Add";
            this.newStudentAddButton.UseVisualStyleBackColor = true;
            this.newStudentAddButton.Click += new System.EventHandler(this.newStudentAddButton_Click);
            // 
            // newStudentResetButton
            // 
            this.newStudentResetButton.Enabled = false;
            this.newStudentResetButton.Location = new System.Drawing.Point(334, 261);
            this.newStudentResetButton.Name = "newStudentResetButton";
            this.newStudentResetButton.Size = new System.Drawing.Size(128, 37);
            this.newStudentResetButton.TabIndex = 9;
            this.newStudentResetButton.Text = "Reset";
            this.newStudentResetButton.UseVisualStyleBackColor = true;
            this.newStudentResetButton.Click += new System.EventHandler(this.newStudentResetButton_Click);
            // 
            // newStudentDeptComboBox
            // 
            this.newStudentDeptComboBox.FormattingEnabled = true;
            this.newStudentDeptComboBox.Location = new System.Drawing.Point(244, 153);
            this.newStudentDeptComboBox.Name = "newStudentDeptComboBox";
            this.newStudentDeptComboBox.Size = new System.Drawing.Size(121, 21);
            this.newStudentDeptComboBox.TabIndex = 10;
            // 
            // newStudentBackButton
            // 
            this.newStudentBackButton.Location = new System.Drawing.Point(517, 261);
            this.newStudentBackButton.Name = "newStudentBackButton";
            this.newStudentBackButton.Size = new System.Drawing.Size(130, 34);
            this.newStudentBackButton.TabIndex = 11;
            this.newStudentBackButton.Text = "Back";
            this.newStudentBackButton.UseVisualStyleBackColor = true;
            this.newStudentBackButton.Click += new System.EventHandler(this.newStudentBackButton_Click);
            // 
            // NewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 459);
            this.Controls.Add(this.newStudentBackButton);
            this.Controls.Add(this.newStudentDeptComboBox);
            this.Controls.Add(this.newStudentResetButton);
            this.Controls.Add(this.newStudentAddButton);
            this.Controls.Add(this.newstudentEnrolmentTypePanel);
            this.Controls.Add(this.newStudentLastNameText);
            this.Controls.Add(this.newStudentFirstNameText);
            this.Controls.Add(this.newStudentStudentIdText);
            this.Controls.Add(this.newStudentDepartmentLabel);
            this.Controls.Add(this.newStudentLastNameLabel);
            this.Controls.Add(this.newStudentFirstNameLabel);
            this.Controls.Add(this.newStudentStudentIdLabel);
            this.Name = "NewStudent";
            this.Text = "NewStudent";
            this.Load += new System.EventHandler(this.NewStudent_Load);
            this.newstudentEnrolmentTypePanel.ResumeLayout(false);
            this.newstudentEnrolmentTypePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newStudentStudentIdLabel;
        private System.Windows.Forms.Label newStudentFirstNameLabel;
        private System.Windows.Forms.Label newStudentLastNameLabel;
        private System.Windows.Forms.Label newStudentDepartmentLabel;
        private System.Windows.Forms.TextBox newStudentStudentIdText;
        private System.Windows.Forms.TextBox newStudentFirstNameText;
        private System.Windows.Forms.TextBox newStudentLastNameText;
        private System.Windows.Forms.Panel newstudentEnrolmentTypePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton newStudentPartTimeRadio;
        private System.Windows.Forms.RadioButton newStudentFullTimeRadio;
        private System.Windows.Forms.Button newStudentAddButton;
        private System.Windows.Forms.Button newStudentResetButton;
        private System.Windows.Forms.ComboBox newStudentDeptComboBox;
        private System.Windows.Forms.Button newStudentBackButton;
    }
}