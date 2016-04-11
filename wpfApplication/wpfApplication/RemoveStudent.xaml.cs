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
    /// Interaction logic for RemoveStudent.xaml
    /// </summary>
    public partial class RemoveStudent : Window
    {
        Student student;
        public RemoveStudent()
        {
            InitializeComponent();
        }

        private void getInfoButton_Click(object sender, RoutedEventArgs e)
        {
            bool found = false;
            foreach(Student s in Eco.getEco().studentList)
            {
                if(s.studentId == this.studentIdText.Text)
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
                    else if(s.enrolType == "Part Time")
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

        private void firstNameText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            StudentRegistration s = new StudentRegistration();
            this.Hide();
            s.Show();
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {

            string id = this.studentIdText.Text;
            MessageBoxResult r = MessageBox.Show("Are you sure you want to remove the student", "", MessageBoxButton.YesNoCancel);
            if(r == MessageBoxResult.Yes)
            {
                Eco.getEco().studentList.Remove(this.student);
                MessageBox.Show("Student deleted successfully");
                StudentRegistration sr = new StudentRegistration();
                this.Hide();
                sr.Show();
            }
           else if(r == MessageBoxResult.Cancel)
            {
                this.Show();
            }
           else if(r == MessageBoxResult.No)
            {
                StudentRegistration sr = new StudentRegistration();
                this.Hide();
                sr.Show();
            }

        }
    }
}
