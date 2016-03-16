using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int ssn = 0;
            
            Employees emp_sal = new SalariedEmployee(name, ssn);
            emp_sal.personalInformation();
            Console.WriteLine("Earned: $" + emp_sal.calculateSalary());
            Console.WriteLine("");

            Employees emp_hourly = new HourlyEmployee(name, ssn);
            emp_hourly.personalInformation();
            Console.WriteLine("Earned: $" + emp_hourly.calculateSalary());
            Console.WriteLine("");

            CommissionEmployee emp_comm = new CommissionEmployee(name, ssn);
            emp_comm.personalInformation();
            Console.WriteLine("Earned: $" + emp_comm.calculateSalesSalary());
            Console.WriteLine("");

            SalaryBasedCommissionEmployee emp_base = new SalaryBasedCommissionEmployee(name, ssn);
            emp_base.personalInformation();
            Console.WriteLine("Earned: $" + emp_base.calculateSalesSalary());
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}
