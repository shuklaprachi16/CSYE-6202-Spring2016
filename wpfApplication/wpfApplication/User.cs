using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzWare.NBuilder;

namespace wpfApplication
{
    public class User
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string name { get; set; }

        public User(string userName, string password, string name)
        {
            this.userName = userName;
            this.password = password;
            this.name = name;

        }

        public User() { }





    }
}
