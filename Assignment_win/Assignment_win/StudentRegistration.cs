using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FizzWare.NBuilder;

namespace Assignment_win
{
    public partial class StudentRegistration : Form
    {
        

        public StudentRegistration()
        {
            InitializeComponent();



            this.studentRegistrationDeptDropDown.DataSource = Student.departmentList;
            this.StudentRegistrationStudentIdText.Text = Student.RandomString(9);
            dataGridViewStudents.DataSource = Eco.getEco().studentList;



        }
        private void newStudentButton_Click(object sender, EventArgs e)
        {
            NewStudent newStudent = new NewStudent();
            this.Hide();
            newStudent.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataGridViewStudents.DataSource = Eco.getEco().studentList;
        }

        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            RemoveStudent r = new RemoveStudent();
            this.Hide();
            r.Show();
        }

        private void editStudentButton_Click(object sender, EventArgs e)
        {
            EditStudent es = new EditStudent();
            this.Hide();
            es.Show();
        }
    }
}
