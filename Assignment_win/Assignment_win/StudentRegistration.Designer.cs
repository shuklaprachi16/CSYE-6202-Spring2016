namespace Assignment_win
{
    partial class StudentRegistration
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
            this.components = new System.ComponentModel.Container();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.studentRegistrationFirstNameLabel = new System.Windows.Forms.Label();
            this.studentRegistrationLastNameLabel = new System.Windows.Forms.Label();
            this.studentRegistrationDeptLabel = new System.Windows.Forms.Label();
            this.studentRegistrationEnrollmentTypeLabel = new System.Windows.Forms.Label();
            this.StudentRegistrationStudentIdText = new System.Windows.Forms.TextBox();
            this.studentRegistrationFirstNameText = new System.Windows.Forms.TextBox();
            this.studentRegistrationLastNameText = new System.Windows.Forms.TextBox();
            this.studentRegistrationDeptDropDown = new System.Windows.Forms.ComboBox();
            this.studentRegistrationFullTimeRadio = new System.Windows.Forms.RadioButton();
            this.studentRegistrationPartRadio = new System.Windows.Forms.RadioButton();
            this.studentRegistrationStudentTable = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.newStudentButton = new System.Windows.Forms.Button();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.editStudentButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentRegistrationStudentTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(34, 34);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(56, 13);
            this.studentIdLabel.TabIndex = 0;
            this.studentIdLabel.Text = "Student Id";
            // 
            // studentRegistrationFirstNameLabel
            // 
            this.studentRegistrationFirstNameLabel.AutoSize = true;
            this.studentRegistrationFirstNameLabel.Location = new System.Drawing.Point(34, 61);
            this.studentRegistrationFirstNameLabel.Name = "studentRegistrationFirstNameLabel";
            this.studentRegistrationFirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.studentRegistrationFirstNameLabel.TabIndex = 1;
            this.studentRegistrationFirstNameLabel.Text = "First Name";
            // 
            // studentRegistrationLastNameLabel
            // 
            this.studentRegistrationLastNameLabel.AutoSize = true;
            this.studentRegistrationLastNameLabel.Location = new System.Drawing.Point(34, 93);
            this.studentRegistrationLastNameLabel.Name = "studentRegistrationLastNameLabel";
            this.studentRegistrationLastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.studentRegistrationLastNameLabel.TabIndex = 2;
            this.studentRegistrationLastNameLabel.Text = "Last Name";
            // 
            // studentRegistrationDeptLabel
            // 
            this.studentRegistrationDeptLabel.AutoSize = true;
            this.studentRegistrationDeptLabel.Location = new System.Drawing.Point(34, 128);
            this.studentRegistrationDeptLabel.Name = "studentRegistrationDeptLabel";
            this.studentRegistrationDeptLabel.Size = new System.Drawing.Size(62, 13);
            this.studentRegistrationDeptLabel.TabIndex = 3;
            this.studentRegistrationDeptLabel.Text = "Department";
            // 
            // studentRegistrationEnrollmentTypeLabel
            // 
            this.studentRegistrationEnrollmentTypeLabel.AutoSize = true;
            this.studentRegistrationEnrollmentTypeLabel.Location = new System.Drawing.Point(34, 162);
            this.studentRegistrationEnrollmentTypeLabel.Name = "studentRegistrationEnrollmentTypeLabel";
            this.studentRegistrationEnrollmentTypeLabel.Size = new System.Drawing.Size(83, 13);
            this.studentRegistrationEnrollmentTypeLabel.TabIndex = 4;
            this.studentRegistrationEnrollmentTypeLabel.Text = "Enrollment Type";
            // 
            // StudentRegistrationStudentIdText
            // 
            this.StudentRegistrationStudentIdText.Enabled = false;
            this.StudentRegistrationStudentIdText.Location = new System.Drawing.Point(157, 31);
            this.StudentRegistrationStudentIdText.Name = "StudentRegistrationStudentIdText";
            this.StudentRegistrationStudentIdText.Size = new System.Drawing.Size(100, 20);
            this.StudentRegistrationStudentIdText.TabIndex = 5;
            // 
            // studentRegistrationFirstNameText
            // 
            this.studentRegistrationFirstNameText.Enabled = false;
            this.studentRegistrationFirstNameText.Location = new System.Drawing.Point(157, 61);
            this.studentRegistrationFirstNameText.Name = "studentRegistrationFirstNameText";
            this.studentRegistrationFirstNameText.Size = new System.Drawing.Size(100, 20);
            this.studentRegistrationFirstNameText.TabIndex = 6;
            // 
            // studentRegistrationLastNameText
            // 
            this.studentRegistrationLastNameText.Enabled = false;
            this.studentRegistrationLastNameText.Location = new System.Drawing.Point(157, 90);
            this.studentRegistrationLastNameText.Name = "studentRegistrationLastNameText";
            this.studentRegistrationLastNameText.Size = new System.Drawing.Size(100, 20);
            this.studentRegistrationLastNameText.TabIndex = 7;
            // 
            // studentRegistrationDeptDropDown
            // 
            this.studentRegistrationDeptDropDown.Enabled = false;
            this.studentRegistrationDeptDropDown.FormattingEnabled = true;
            this.studentRegistrationDeptDropDown.Location = new System.Drawing.Point(157, 128);
            this.studentRegistrationDeptDropDown.Name = "studentRegistrationDeptDropDown";
            this.studentRegistrationDeptDropDown.Size = new System.Drawing.Size(100, 21);
            this.studentRegistrationDeptDropDown.TabIndex = 8;
            // 
            // studentRegistrationFullTimeRadio
            // 
            this.studentRegistrationFullTimeRadio.AutoSize = true;
            this.studentRegistrationFullTimeRadio.Enabled = false;
            this.studentRegistrationFullTimeRadio.Location = new System.Drawing.Point(157, 162);
            this.studentRegistrationFullTimeRadio.Name = "studentRegistrationFullTimeRadio";
            this.studentRegistrationFullTimeRadio.Size = new System.Drawing.Size(67, 17);
            this.studentRegistrationFullTimeRadio.TabIndex = 9;
            this.studentRegistrationFullTimeRadio.TabStop = true;
            this.studentRegistrationFullTimeRadio.Text = "Full Time";
            this.studentRegistrationFullTimeRadio.UseVisualStyleBackColor = true;
            // 
            // studentRegistrationPartRadio
            // 
            this.studentRegistrationPartRadio.AutoSize = true;
            this.studentRegistrationPartRadio.Enabled = false;
            this.studentRegistrationPartRadio.Location = new System.Drawing.Point(157, 185);
            this.studentRegistrationPartRadio.Name = "studentRegistrationPartRadio";
            this.studentRegistrationPartRadio.Size = new System.Drawing.Size(66, 17);
            this.studentRegistrationPartRadio.TabIndex = 10;
            this.studentRegistrationPartRadio.TabStop = true;
            this.studentRegistrationPartRadio.Text = "Part time";
            this.studentRegistrationPartRadio.UseVisualStyleBackColor = true;
            // 
            // studentRegistrationStudentTable
            // 
            this.studentRegistrationStudentTable.ColumnCount = 5;
            this.studentRegistrationStudentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.studentRegistrationStudentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.studentRegistrationStudentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.studentRegistrationStudentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.studentRegistrationStudentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.studentRegistrationStudentTable.Controls.Add(this.label5, 4, 0);
            this.studentRegistrationStudentTable.Controls.Add(this.label4, 3, 0);
            this.studentRegistrationStudentTable.Controls.Add(this.label3, 2, 0);
            this.studentRegistrationStudentTable.Controls.Add(this.label2, 1, 0);
            this.studentRegistrationStudentTable.Controls.Add(this.label1, 0, 0);
            this.studentRegistrationStudentTable.Location = new System.Drawing.Point(725, 442);
            this.studentRegistrationStudentTable.Name = "studentRegistrationStudentTable";
            this.studentRegistrationStudentTable.RowCount = 2;
            this.studentRegistrationStudentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentRegistrationStudentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentRegistrationStudentTable.Size = new System.Drawing.Size(10, 10);
            this.studentRegistrationStudentTable.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 5);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 5);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 5);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 5);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 5);
            this.label1.TabIndex = 0;
            this.label1.Text = "StudentId";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AutoGenerateColumns = false;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.enrolTypeDataGridViewTextBoxColumn});
            this.dataGridViewStudents.DataSource = this.studentBindingSource;
            this.dataGridViewStudents.Location = new System.Drawing.Point(51, 268);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(545, 150);
            this.dataGridViewStudents.TabIndex = 12;
            // 
            // newStudentButton
            // 
            this.newStudentButton.AccessibleName = "";
            this.newStudentButton.Location = new System.Drawing.Point(420, 34);
            this.newStudentButton.Name = "newStudentButton";
            this.newStudentButton.Size = new System.Drawing.Size(147, 23);
            this.newStudentButton.TabIndex = 13;
            this.newStudentButton.Text = "New Student";
            this.newStudentButton.UseVisualStyleBackColor = true;
            this.newStudentButton.Click += new System.EventHandler(this.newStudentButton_Click);
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.AccessibleName = "";
            this.removeStudentButton.Location = new System.Drawing.Point(420, 63);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(147, 23);
            this.removeStudentButton.TabIndex = 14;
            this.removeStudentButton.Text = "Remove Student";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // editStudentButton
            // 
            this.editStudentButton.AccessibleName = "";
            this.editStudentButton.Location = new System.Drawing.Point(420, 93);
            this.editStudentButton.Name = "editStudentButton";
            this.editStudentButton.Size = new System.Drawing.Size(147, 23);
            this.editStudentButton.TabIndex = 15;
            this.editStudentButton.Text = "Edit Student";
            this.editStudentButton.UseVisualStyleBackColor = true;
            this.editStudentButton.Click += new System.EventHandler(this.editStudentButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(51, 239);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 17;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "studentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "studentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // enrolTypeDataGridViewTextBoxColumn
            // 
            this.enrolTypeDataGridViewTextBoxColumn.DataPropertyName = "enrolType";
            this.enrolTypeDataGridViewTextBoxColumn.HeaderText = "enrolType";
            this.enrolTypeDataGridViewTextBoxColumn.Name = "enrolTypeDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Assignment_win.Student);
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 464);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.editStudentButton);
            this.Controls.Add(this.removeStudentButton);
            this.Controls.Add(this.newStudentButton);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.studentRegistrationStudentTable);
            this.Controls.Add(this.studentRegistrationPartRadio);
            this.Controls.Add(this.studentRegistrationFullTimeRadio);
            this.Controls.Add(this.studentRegistrationDeptDropDown);
            this.Controls.Add(this.studentRegistrationLastNameText);
            this.Controls.Add(this.studentRegistrationFirstNameText);
            this.Controls.Add(this.StudentRegistrationStudentIdText);
            this.Controls.Add(this.studentRegistrationEnrollmentTypeLabel);
            this.Controls.Add(this.studentRegistrationDeptLabel);
            this.Controls.Add(this.studentRegistrationLastNameLabel);
            this.Controls.Add(this.studentRegistrationFirstNameLabel);
            this.Controls.Add(this.studentIdLabel);
            this.MaximizeBox = false;
            this.Name = "StudentRegistration";
            this.Text = "StudentRegistration";
            this.studentRegistrationStudentTable.ResumeLayout(false);
            this.studentRegistrationStudentTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.Label studentRegistrationFirstNameLabel;
        private System.Windows.Forms.Label studentRegistrationLastNameLabel;
        private System.Windows.Forms.Label studentRegistrationDeptLabel;
        private System.Windows.Forms.Label studentRegistrationEnrollmentTypeLabel;
        private System.Windows.Forms.TextBox StudentRegistrationStudentIdText;
        private System.Windows.Forms.TextBox studentRegistrationFirstNameText;
        private System.Windows.Forms.TextBox studentRegistrationLastNameText;
        private System.Windows.Forms.ComboBox studentRegistrationDeptDropDown;
        private System.Windows.Forms.RadioButton studentRegistrationFullTimeRadio;
        private System.Windows.Forms.RadioButton studentRegistrationPartRadio;
        private System.Windows.Forms.TableLayoutPanel studentRegistrationStudentTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrolTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button newStudentButton;
        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.Button editStudentButton;
        private System.Windows.Forms.Button refreshButton;
    }
}