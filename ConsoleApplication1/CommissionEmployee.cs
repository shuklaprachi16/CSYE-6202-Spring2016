﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CommissionEmployee:Employees, IEmployee
    {
        private String name;
        private int ssn;
        private float grossSales= 0.0f;
        private float commissionRate = 0.0f;
        private float earned = 0.0f;


     public CommissionEmployee(String name, int ssn) : base(name, ssn) {
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

            while (test1)
            {
                try {
                    Console.Write("Gross Sales: $");
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
                    Console.WriteLine("Commission rate: $");
                    commissionRate = float.Parse(Console.ReadLine());
                    test2 = false;
                }
                catch
                {
                    Console.WriteLine("'Please enter a correct integer or float value for Commission rate'");
                    test2 = true;
                }
            }
            earned = CalculateEarned(grossSales, commissionRate);
            return earned;


        }
        public float CalculateEarned(float gross, float rate) {
            float earned = gross * rate;
            return earned;
        }

        public override void personalInformation()
        {
            bool test1 = true;
            bool test2 = true;
            while (test2)
            {
                Console.Write("Commission employee: ");
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
