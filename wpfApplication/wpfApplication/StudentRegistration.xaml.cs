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
    /// Interaction logic for StudentRegistration.xaml
    /// </summary>
    public partial class StudentRegistration : Window
    {
        public StudentRegistration()
        {
            InitializeComponent();
            studentIdText.Text = Student.RandomString(9);
            studentTable.ItemsSource = Eco.getEco().studentList;
        }

        private void newStudentButton_Click(object sender, RoutedEventArgs e)
        {
            NewStudent ns = new NewStudent();
            this.Hide();
            ns.Show();

        }

        private void removeStudentButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveStudent rs = new RemoveStudent();
            this.Hide();
            rs.Show();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            EditStudent es = new EditStudent();
            this.Hide();
            es.Show();
        }
    }
}
