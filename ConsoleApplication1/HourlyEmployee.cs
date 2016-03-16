using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HourlyEmployee : Employees
    {
        private String name;
        private int ssn;
        private float hourlyWage = 0.0f;
        private float hoursWorked = 0.0f;
        private float earned= 0.0f ;

        public HourlyEmployee(String name, int ssn) : base(name, ssn) {
            name = this.name;
            ssn = this.ssn;
        }

        public override float calculateSalary()
        {
            bool tryagain = true;
            bool tryAgain2 = true;
            while(tryagain){
                try
                {
                    Console.Write("Hourly wage: $");
                    hourlyWage = float.Parse(Console.ReadLine());
                    tryagain = false;
                }
                catch {
                    Console.WriteLine("'Please enter integer or float value for Hourly wage'");
                    tryagain = true;
                }
                }

            while (tryAgain2)
            {
                try {
                    Console.Write("Hours Worked: ");
                    hoursWorked = float.Parse(Console.ReadLine());
                    tryAgain2 = false;
                }
                catch
                {
                    Console.WriteLine("'Please enter a correct integer or float value for Hours worked'");
                    tryagain = true;
                }
            }
            earned = CalculatEarned(hoursWorked, hourlyWage);
            return earned;


        }
        public float CalculatEarned(float hours, float wage) {
            if (hours > 40)
            {
                float earned40 = 40 * wage;
                float extra = ((float)((hours - 40) * 1.5) * wage);
                return earned40 + extra;
            }
            else
            {
                return hours * wage;
            }
        }

        public override void personalInformation()
        {
            bool test1 = true;
            bool test2 = true;
            while (test2)
            {
                Console.Write("Hourly employee: ");
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

            {
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
                        Console.WriteLine("'Please enter valid 9 digits integer value'");
                        test1 = true;
                    }
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
