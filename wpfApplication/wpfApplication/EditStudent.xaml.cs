using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wpfApplication
{
    /// <summary>
    /// Interaction logic for EditStudent.xaml
    /// </summary>
    public partial class EditStudent : Window
    {
        Student student;
        public EditStudent()
        {
            InitializeComponent();
        }

        private void getInfoButton_Click(object sender, RoutedEventArgs e)
        {
            bool found = false;
            foreach (Student s in Eco.getEco().studentList)
            {
                if (s.studentId == this.studentIdText.Text)
                {
                    found = true;
                    this.student = s;
                    this.firstNameText.Text = s.firstName;
                    this.lastNameText.Text = s.lastName;
                    this.deptComboBox.ItemsSource = Student.departmentList;
                    this.deptComboBox.SelectedValue = s.department;
                    if (s.enrolType == "Full Time")
                    {
                        this.fullTimeRadio.IsChecked = true;
                    }
                    else if (s.enrolType == "Part Time")
                    {
                        this.partTimeRadio.IsChecked = true;
                    }
                }

            }
            if (found == false)
            {
                MessageBox.Show("Student with this Id does not exist, please enter correct id");
            }
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (studentIdText.Text.Length == 0 || firstNameText.Text.Length == 0 || lastNameText.Text.Length == 0 || deptComboBox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all the values");
            }
            else
            {
                MessageBoxResult r = MessageBox.Show("Are you sure you want to Update the student", "", MessageBoxButton.YesNoCancel);
                if (r == MessageBoxResult.Yes)
                {
                    student.firstName = this.firstNameText.Text;
                    student.lastName = this.lastNameText.Text;
                    student.studentId = this.studentIdText.Text;
                    student.department = this.deptComboBox.Text;
                    if (partTimeRadio.IsChecked.Equals(true))
                    {
                        student.enrolType = "Part Time";
                    }
                    else
                    {
                        student.enrolType = "Full Time";
                    }
                    MessageBox.Show("student Updated successfully!!");
                    StudentRegistration sr = new StudentRegistration();
                    this.Hide();
                    sr.Show();
                }
                else if (r == MessageBoxResult.No )
                {
                    StudentRegistration sr = new StudentRegistration();
                    this.Hide();
                    sr.Show();
                }
                else if( r == MessageBoxResult.Cancel)
                {
                    this.Show();
                }

            }
        }
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            StudentRegistration s = new StudentRegistration();
            this.Hide();
            s.Show();
        }
    }
}
