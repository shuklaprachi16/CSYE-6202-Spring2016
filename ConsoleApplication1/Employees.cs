using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Employees

    {
        private String employeeName;
        private int ssn;
        private float earned;

        public Employees(String name, int ssn) {
            name = this.employeeName;
            ssn = this.ssn;
        }

        public abstract void personalInformation();
        public abstract float calculateSalary();
    }
}
