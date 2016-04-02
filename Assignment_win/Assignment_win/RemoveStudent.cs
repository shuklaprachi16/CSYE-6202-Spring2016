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
    public partial class RemoveStudent : Form
    {
      
        public RemoveStudent()
        {
            
            InitializeComponent();

            this.infoPanel.Hide();
            this.buttonPanel.Hide();

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void partTimeRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void getInfoButton_Click(object sender, EventArgs e)
        {
            string id = this.removeStudentStudentIdText.Text;
            bool found = true;
            foreach (Student s in Eco.getEco().studentList)
            {
                if(s.studentId == id)
                {
                    found = false;
                    this.studentFirstNameText.Text = s.firstName;
                    this.StudentLastNameText.Text = s.lastName;
                    this.studentdepartment.Text = s.department;
                    if(s.enrolType == "Full Time")
                    {
                        this.fullTimeRadio.Checked = true;

                    }
                    else if(s.enrolType == "Part Time")
                    {
                        this.partTimeRadio.Checked = true;
                    }
                    infoPanel.Show();
                    buttonPanel.Show();
                }
            }
            if(found == true)
            {
                System.Windows.Forms.MessageBox.Show("No student with such Id exists");

            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string id = this.removeStudentStudentIdText.Text;
            
            foreach(Student s in Eco.getEco().studentList)
            {
                if(s.studentId == id)
                {
                    
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove the student", "Warning", MessageBoxButtons.YesNo);
                    if(dialogResult == DialogResult.Yes)
                    {
                        Eco.getEco().studentList.Remove(s);
                        System.Windows.Forms.MessageBox.Show("Student Removed Successfully");
                    }
                    else
                    {
                        this.Show();
                    }
                  
                    StudentRegistration sr = new StudentRegistration();
                    this.Hide();
                    sr.Show();
                    break;
                   
                }
            }
           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            StudentRegistration s = new StudentRegistration();
            this.Hide();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentRegistration sr = new StudentRegistration();
            this.Hide();
            sr.Show();
        }
    }
}
