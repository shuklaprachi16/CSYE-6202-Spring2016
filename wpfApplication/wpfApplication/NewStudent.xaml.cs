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
    /// Interaction logic for NewStudent.xaml
    /// </summary>
    public partial class NewStudent : Window
    {
        string enrl;
        public NewStudent()
        {
            InitializeComponent();
            studentIdText.Text = Student.RandomString(9);
            deptComboBox.ItemsSource = Student.departmentList;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void newStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if (partTimeRadio.IsChecked == true)
            {
                enrl = "Part Time";
            }
            else
            {
                enrl = "Full Time";
            }
            if (studentIdText.Text.Length == 0 || firstNameText.Text.Length == 0 || lastNameText.Text.Length == 0 || deptComboBox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all the values");
            }
            else
            {
                Student student = new Student(this.studentIdText.Text, this.firstNameText.Text, this.lastNameText.Text, this.deptComboBox.Text, this.enrl);
                Eco.getEco().studentList.Add(student);
                MessageBox.Show("Student Prachi added successfully");

                StudentRegistration s = new StudentRegistration();
                this.Hide();
                s.Show();
            }
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            firstNameText.Clear();
            lastNameText.Clear();
            fullTimeRadio.IsChecked = false;
            partTimeRadio.IsChecked = false;
        }

        private void studentIdText_TextChanged(object sender, TextChangedEventArgs e)
        {
           // addButton.IsEnabled = true;
            //resetButton.IsEnabled = true;
        }

        private void firstNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            addButton.IsEnabled = true;
            resetButton.IsEnabled = true;
        }

        private void lastNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
           addButton.IsEnabled = true;
            resetButton.IsEnabled = true;
        }

        private void deptComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           addButton.IsEnabled = true;
            resetButton.IsEnabled = true;
        }
    }
}
