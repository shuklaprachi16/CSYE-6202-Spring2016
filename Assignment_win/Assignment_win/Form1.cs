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
    public partial class Welcome : Form

    {
        int count = 0;
        public Welcome()
        {
            InitializeComponent();
        }
       

        private void form1SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.eco = Eco.getEco();
            signUp.Show();
        }

        private void form1SignInButton_Click(object sender, EventArgs e)
        {
            if (this.form1UserNameText.Text.Length == 0 || this.form1PasswordText.Text.Length == 0)
            {
                MessageBox.Show("Please enter both UserName and password");
            }
            else
            {
                bool found = true;

                foreach (User u in Eco.getEco().userList)
                {
                    if (u.userName == form1UserNameText.Text & u.password == form1PasswordText.Text)
                    {
                        this.Hide();
                        StudentRegistration studentRegistration = new StudentRegistration();
                        studentRegistration.Show();
                        found = false;
                        break;

                    }

                }
                if (found == true)
                {
                    System.Windows.Forms.MessageBox.Show("Please enter valid credentials");
                    count = count + 1;
                    if (count == 3)
                    {
                        System.Windows.Forms.MessageBox.Show("Sorry application closed due to security reasons");

                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
