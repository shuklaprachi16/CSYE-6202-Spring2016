using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_win
{
    public class Student
    {
        public static Random random = new Random();
        public string studentId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string department { get; set; }
        public string enrolType { get; set; }

        public  Student(string studentId, string firstName, string lastName, string department, string enrolType) {
            this.studentId = studentId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.department = department;
            this.enrolType = enrolType;
        }

        public Student() { }

        public static List<string> departmentList = new List<string>() { "Information Systems", "International Affairs", "Nursing", "Pharmacy", "Professional Studies", "Psychology", "Public Administration" };

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

          
            string a = new string(Enumerable.Repeat(chars, 3).Select(s => s[random.Next(s.Length)]).ToArray());
            string b = new string(Enumerable.Repeat(chars, 2).Select(s => s[random.Next(s.Length)]).ToArray());
            string c = new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());

            return a + "-" + b + "-" + c;
          //  return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

       
       
    }
}
