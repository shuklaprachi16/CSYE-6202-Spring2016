﻿using System;
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
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
            this.infoPanel.Hide();
            this.buttonPanel.Hide();
        }

        private void getInfoButton_Click(object sender, EventArgs e)
        {
            string id = this.removeStudentStudentIdText.Text;
            bool found = true;
            foreach (Student s in Eco.getEco().studentList)
            {
                if (s.studentId == id)
                {
                    found = false;
                    this.studentFirstNameText.Text = s.firstName;
                    this.StudentLastNameText.Text = s.lastName;
                    this.comboBox1.DataSource = Student.departmentList;

                    if (s.enrolType == "Full Time")
                    {
                        this.fullTimeRadio.Checked = true;

                    }
                    else if (s.enrolType == "Part Time")
                    {
                        this.partTimeRadio.Checked = true;
                    }
                    infoPanel.Show();
                    buttonPanel.Show();
                }
            }
            if (found == true)
            {
                System.Windows.Forms.MessageBox.Show("No student with such Id exists");

            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string id = this.removeStudentStudentIdText.Text;

            if (this.studentFirstNameText.Text.Length == 0)
            {
                MessageBox.Show("Please enter First Name");
            }
            else if (this.StudentLastNameText.Text.Length == 0)
            {
                MessageBox.Show("Please enter Last Name");

            }

            else if (this.comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter Department ");
            }

            else { 
            foreach (Student s in Eco.getEco().studentList)
            {
                if (s.studentId == id)
                {

                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to update the student", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        s.firstName = this.studentFirstNameText.Text;
                        s.lastName = this.StudentLastNameText.Text;
                        s.department = this.comboBox1.Text;
                        if (fullTimeRadio.Checked == true)
                        {
                            s.enrolType = "Full Time";
                        }
                        else if (partTimeRadio.Checked == true)
                        {
                            s.enrolType = "Part Time";
                        }
                        System.Windows.Forms.MessageBox.Show("Student details updated Successfully");
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

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            StudentRegistration s = new StudentRegistration();
            this.Hide();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentRegistration s = new StudentRegistration();
            this.Hide();
            s.Show();
        }
    }
}
