namespace Assignment_win
{
    partial class RemoveStudent
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
            this.removeStudentStudentIdText = new System.Windows.Forms.TextBox();
            this.removeStudentStudentIdLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.studentdepartment = new System.Windows.Forms.TextBox();
            this.StudentLastNameText = new System.Windows.Forms.TextBox();
            this.studentFirstNameText = new System.Windows.Forms.TextBox();
            this.newStudentDepartmentLabel = new System.Windows.Forms.Label();
            this.studentLastNameLabel = new System.Windows.Forms.Label();
            this.studentFirstNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.partTimeRadio = new System.Windows.Forms.RadioButton();
            this.fullTimeRadio = new System.Windows.Forms.RadioButton();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.getInfoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.infoPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeStudentStudentIdText
            // 
            this.removeStudentStudentIdText.Location = new System.Drawing.Point(218, 29);
            this.removeStudentStudentIdText.Name = "removeStudentStudentIdText";
            this.removeStudentStudentIdText.Size = new System.Drawing.Size(121, 20);
            this.removeStudentStudentIdText.TabIndex = 15;
            // 
            // removeStudentStudentIdLabel
            // 
            this.removeStudentStudentIdLabel.AutoSize = true;
            this.removeStudentStudentIdLabel.Location = new System.Drawing.Point(34, 32);
            this.removeStudentStudentIdLabel.Name = "removeStudentStudentIdLabel";
            this.removeStudentStudentIdLabel.Size = new System.Drawing.Size(58, 13);
            this.removeStudentStudentIdLabel.TabIndex = 11;
            this.removeStudentStudentIdLabel.Text = "Student ID";
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.studentdepartment);
            this.infoPanel.Controls.Add(this.StudentLastNameText);
            this.infoPanel.Controls.Add(this.studentFirstNameText);
            this.infoPanel.Controls.Add(this.newStudentDepartmentLabel);
            this.infoPanel.Controls.Add(this.studentLastNameLabel);
            this.infoPanel.Controls.Add(this.studentFirstNameLabel);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Controls.Add(this.partTimeRadio);
            this.infoPanel.Controls.Add(this.fullTimeRadio);
            this.infoPanel.Location = new System.Drawing.Point(13, 55);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(640, 189);
            this.infoPanel.TabIndex = 19;
            // 
            // studentdepartment
            // 
            this.studentdepartment.Location = new System.Drawing.Point(205, 108);
            this.studentdepartment.Name = "studentdepartment";
            this.studentdepartment.Size = new System.Drawing.Size(121, 20);
            this.studentdepartment.TabIndex = 24;
            // 
            // StudentLastNameText
            // 
            this.StudentLastNameText.Location = new System.Drawing.Point(205, 68);
            this.StudentLastNameText.Name = "StudentLastNameText";
            this.StudentLastNameText.Size = new System.Drawing.Size(121, 20);
            this.StudentLastNameText.TabIndex = 23;
            // 
            // studentFirstNameText
            // 
            this.studentFirstNameText.Location = new System.Drawing.Point(205, 22);
            this.studentFirstNameText.Name = "studentFirstNameText";
            this.studentFirstNameText.Size = new System.Drawing.Size(121, 20);
            this.studentFirstNameText.TabIndex = 22;
            // 
            // newStudentDepartmentLabel
            // 
            this.newStudentDepartmentLabel.AutoSize = true;
            this.newStudentDepartmentLabel.Location = new System.Drawing.Point(17, 108);
            this.newStudentDepartmentLabel.Name = "newStudentDepartmentLabel";
            this.newStudentDepartmentLabel.Size = new System.Drawing.Size(62, 13);
            this.newStudentDepartmentLabel.TabIndex = 21;
            this.newStudentDepartmentLabel.Text = "Department";
            // 
            // studentLastNameLabel
            // 
            this.studentLastNameLabel.AutoSize = true;
            this.studentLastNameLabel.Location = new System.Drawing.Point(17, 68);
            this.studentLastNameLabel.Name = "studentLastNameLabel";
            this.studentLastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.studentLastNameLabel.TabIndex = 20;
            this.studentLastNameLabel.Text = "Last Name";
            // 
            // studentFirstNameLabel
            // 
            this.studentFirstNameLabel.AutoSize = true;
            this.studentFirstNameLabel.Location = new System.Drawing.Point(17, 25);
            this.studentFirstNameLabel.Name = "studentFirstNameLabel";
            this.studentFirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.studentFirstNameLabel.TabIndex = 19;
            this.studentFirstNameLabel.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enrolment Type";
            // 
            // partTimeRadio
            // 
            this.partTimeRadio.AutoSize = true;
            this.partTimeRadio.Location = new System.Drawing.Point(536, 64);
            this.partTimeRadio.Name = "partTimeRadio";
            this.partTimeRadio.Size = new System.Drawing.Size(70, 17);
            this.partTimeRadio.TabIndex = 1;
            this.partTimeRadio.TabStop = true;
            this.partTimeRadio.Text = "Part Time";
            this.partTimeRadio.UseVisualStyleBackColor = true;
            this.partTimeRadio.CheckedChanged += new System.EventHandler(this.partTimeRadio_CheckedChanged);
            // 
            // fullTimeRadio
            // 
            this.fullTimeRadio.AutoSize = true;
            this.fullTimeRadio.Location = new System.Drawing.Point(446, 66);
            this.fullTimeRadio.Name = "fullTimeRadio";
            this.fullTimeRadio.Size = new System.Drawing.Size(67, 17);
            this.fullTimeRadio.TabIndex = 0;
            this.fullTimeRadio.TabStop = true;
            this.fullTimeRadio.Text = "Full Time";
            this.fullTimeRadio.UseVisualStyleBackColor = true;
            this.fullTimeRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.cancelButton);
            this.buttonPanel.Controls.Add(this.removeButton);
            this.buttonPanel.Location = new System.Drawing.Point(127, 253);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(455, 100);
            this.buttonPanel.TabIndex = 20;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(272, 28);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 38);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(59, 28);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(110, 38);
            this.removeButton.TabIndex = 0;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // getInfoButton
            // 
            this.getInfoButton.Location = new System.Drawing.Point(399, 26);
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.Size = new System.Drawing.Size(101, 23);
            this.getInfoButton.TabIndex = 2;
            this.getInfoButton.Text = "Get Info";
            this.getInfoButton.UseVisualStyleBackColor = true;
            this.getInfoButton.Click += new System.EventHandler(this.getInfoButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getInfoButton);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.removeStudentStudentIdText);
            this.Controls.Add(this.removeStudentStudentIdLabel);
            this.Name = "RemoveStudent";
            this.Text = "RemoveStudent";
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox removeStudentStudentIdText;
        private System.Windows.Forms.Label removeStudentStudentIdLabel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.RadioButton partTimeRadio;
        private System.Windows.Forms.RadioButton fullTimeRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox studentdepartment;
        private System.Windows.Forms.TextBox StudentLastNameText;
        private System.Windows.Forms.TextBox studentFirstNameText;
        private System.Windows.Forms.Label newStudentDepartmentLabel;
        private System.Windows.Forms.Label studentLastNameLabel;
        private System.Windows.Forms.Label studentFirstNameLabel;
        private System.Windows.Forms.Button getInfoButton;
        private System.Windows.Forms.Button button1;
    }
}