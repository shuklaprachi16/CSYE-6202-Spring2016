using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_win
{
    public partial class NewStudent : Form
    {
        string enrolType;
        string dept;
        public NewStudent()
        {
            InitializeComponent();
            newStudentStudentIdText.Text = Student.RandomString(9);
            newStudentDeptComboBox.DataSource = Student.departmentList;
            newStudentFullTimeRadio.Checked = true;
        }

        private void newStudentAddButton_Click(object sender, EventArgs e)
        {

            if (this.newStudentFirstNameText.Text.Length == 0)
            {
                MessageBox.Show("Please enter First Name");
            }
            else if (this.newStudentLastNameText.Text.Length == 0)
            {
                MessageBox.Show("Please enter Last Name");

            }

            else if (this.newStudentDeptComboBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter Department ");
            }

          
            else
            {
                if (newStudentFullTimeRadio.Checked == true)
                {
                    enrolType = "Full Time";
                }
                else if (newStudentPartTimeRadio.Checked == true)
                {
                    enrolType = "Part Time";
                }


                dept = newStudentDeptComboBox.Text;

                Student student = new Student(newStudentStudentIdText.Text, newStudentFirstNameText.Text, newStudentLastNameText.Text, dept, enrolType);
                Eco.getEco().studentList.Add(student);
                List<Student> lis = Eco.getEco().studentList;
            }
        }
        private void newStudentBackButton_Click(object sender, EventArgs e)
        {
            StudentRegistration s = new StudentRegistration();
            this.Hide();
            s.Show();
        }

        private void newStudentResetButton_Click(object sender, EventArgs e)
        {
            newStudentFirstNameText.Clear();
            newStudentLastNameText.Clear();
            newStudentFullTimeRadio.Checked = false;
            newStudentPartTimeRadio.Checked = false;
            Cursor.Position.Equals(newStudentFirstNameText);
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {

        }

        private void newStudentFirstNameText_TextChanged(object sender, EventArgs e)
        {
            this.newStudentAddButton.Enabled = true;
            this.newStudentResetButton.Enabled = true;
        }

        private void newStudentLastNameText_TextChanged(object sender, EventArgs e)
        {
            this.newStudentAddButton.Enabled = true;
            this.newStudentResetButton.Enabled = true;

        }
    }
}
