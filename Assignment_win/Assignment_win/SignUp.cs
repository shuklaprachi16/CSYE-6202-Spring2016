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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        public Eco eco;

        private void signUpSignUpButton_Click_1(object sender, EventArgs e)
        {
            if (this.signUpNameText.Text.Length == 0 || this.signUpUserNameText.TextLength == 0 || this.SignUpPasswordText.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                User user = new User(signUpUserNameText.Text, SignUpPasswordText.Text, signUpNameText.Text);
                eco.addUser(user);
                MessageBox.Show("User Added, Please sign in to continue");
                Welcome w = new Welcome();
                this.Hide();
                w.Show();
                // this.Hide();

                // UserPage userPage = new UserPage();
                //userPage.user = user;
                //userPage.Show();
            }
        }
        private void userPageBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome form1 = new Welcome();
            form1.Show();
        }
    }
}
