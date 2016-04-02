using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FizzWare.NBuilder;

namespace Assignment_win
{
    static class Program
    {

       

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
          
          //  var userss = Builder<User>.CreateListOfSize(10).All().With(c => c.userName = Faker.Name.First()).
            //                                                      With(c => c.password = Faker.Name.Last()).
              //                                                    With(c => c.name = Faker.Name.FullName()).Build();

            //userss = Eco.getEco().userList;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome());



        }
      
    }
}
