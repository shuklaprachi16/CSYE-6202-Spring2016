using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class SalariedEmployee : Employees
    {
        private String name;
        private int ssn;
        private float weeklySalary;
        private float earned = 0.0f;

        public SalariedEmployee(string name, int ssn) : base(name, ssn) //calling base constructor
        {
            name = this.name;
            ssn = this.ssn;

        }

        public override float calculateSalary()
        {
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    Console.Write("Weekly Salary: ");
                    weeklySalary = float.Parse(Console.ReadLine());
                    tryAgain = false;
                }
                catch
                {
                    Console.WriteLine("'please enter correct float/integer value for weekly salary'");
                    tryAgain = true;
                }

            }

            earned = calculateEarned(weeklySalary);
            return earned;
        }

        public float calculateEarned(float weeklyWage)
        {
            float earned;
            earned = weeklyWage;
            return earned;

        }

        public override void personalInformation()
        {
            bool test1 = true;
            bool test2 = true;
            while (test2)
            {
                Console.Write("Salaried employee: ");
                name = Console.ReadLine();

                if (UserEnteredEmptyName(name))
                {
                    Console.WriteLine("'please enter valid name'");
                    test2 = true;
                }
                else
                {
                    test2 = false;
                }
            }

            while (test1)
            {
                try
                {
                    Console.Write("Social security number: ");
                    ssn = int.Parse(Console.ReadLine());
                    if (UserEnteredInvalidSSN(ssn))
                    {
                        Console.WriteLine("'Please enter 9 digits integer value'");
                        test1 = true;
                    }
                    else {
                        test1 = false;
                    }
                }
                catch
                {
                    Console.WriteLine("'Please enter 9 digits integer value'");
                    test1 = true;
                }
            }
        }

        public static bool UserEnteredEmptyName(string name)
        {
            bool result = false;
            if (name.Length.Equals(0))
            {
                result = true;
            }
            return result;
        }

        public static bool UserEnteredInvalidSSN(int ssn)
        {
            bool result = false;
            if (ssn.ToString().Length.Equals(9))
            {
                result = false;
            }
            else {
               result = true;
            }
            return result;
        }
    }
}
