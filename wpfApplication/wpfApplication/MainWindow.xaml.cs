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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void signInButton_Click(object sender, RoutedEventArgs e)
        {

            if (userNameText.Text == "demouser" & passwordBox.Password == "demouser")
            {
                Eco.getEco().addUser();
                StudentRegistration s = new StudentRegistration();
                this.Hide();
                s.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
                count = count + 1;
                if(count == 3)
                {
                    MessageBox.Show("No. of attempts exceeds");
                        System.Environment.Exit(1);
                    

                }
            }
            {

            }
        }
    }
}
