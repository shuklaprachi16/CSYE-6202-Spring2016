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
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
        }

        public User user;
        public Eco eco;

        private void UserPage_Load(object sender, EventArgs e)
        {
            userPageSuccessLabel.Text = user.name;
        }
    }
    }

