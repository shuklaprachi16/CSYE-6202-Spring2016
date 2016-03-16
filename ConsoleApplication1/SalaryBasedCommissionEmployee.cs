using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SalaryBasedCommissionEmployee : Employees, IEmployee
    {
        private String name;
        private int ssn;
        private float grossSales = 0.0f;
        private float commissionRate = 0.0f;
        private float baseSalary = 0.0f;
        private float earned = 0.0f;

        public SalaryBasedCommissionEmployee(String name, int ssn) : base(name, ssn) {
            name = this.name;
            ssn = this.ssn;
        }

        public override float calculateSalary()
        {
            throw new NotImplementedException();
        }

        public float calculateSalesSalary()
        {
            bool test1 = true;
            bool test2 = true;
            bool test3 = true;

            while (test1)
            {
                try {
                    Console.Write("Gross sales: $");
                    grossSales = float.Parse(Console.ReadLine());
                    test1 = false;
                }
                catch
                {
                    Console.WriteLine("'Please enter a correct integer or float value for Gross Sales'");
                    test1 = true;
                }
            }

            while (test2)
            {
                try {
                    Console.Write("Commission rate: ");
                    commissionRate = float.Parse(Console.ReadLine());
                    test2 = false;
                }
                catch
                {
                    Console.WriteLine("'Please enter a correct integer or float value for Commssion rate'");
                    test2 = true;
                }
            }
            while (test3)
            {
                try {
                    Console.Write("Base Salary: $");
                    baseSalary = float.Parse(Console.ReadLine());

                    test3 = false;
                }
                catch
                {
                    Console.WriteLine("Please enter a correct integer or float value for Base Salary");
                    test3 = true;
                }
            }
            earned = CalculateEarned(baseSalary, grossSales, commissionRate);
            return earned;

        }
        public float CalculateEarned(float basesalary, float grosssale, float commissionrate) {
            float earned = basesalary + (grosssale * commissionrate);
            return earned;

        }

        public override void personalInformation()
        {
            bool test1 = true;
            bool test2 = true;
            while (test2)
            {
                Console.Write("Base Salaried commission employee: ");
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
