using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzWare.NBuilder;

namespace Assignment_win
{
    public class Eco
    {
        public static Eco eco;
        List<string> enrolType = new List<string>() { "Full Time", "Part Time" };
        public static Eco getEco()
        {
            if(eco == null)
            {
                eco = new Eco();
            }
            return eco;
        }


       public List<User> userList = new List<User>();
        public List<Student> studentList = new List<Student>();

        public void addUser(User user)
        {
           
            userList.Add(user);
            for (int i = 0; i < 2; i++)
            {
                Student student = Builder<Student>.CreateNew().With(c => c.studentId = Student.RandomString(9)).
                                                                   With(c => c.firstName = Faker.Name.First()).
                                                                   With(c => c.lastName = Faker.Name.Last()).
                                                                   With(c => c.department = Student.departmentList[getRandomIndex()]).
                                                                   With(c => c.enrolType = enrolType[getRandomEnrolType()]).
                                                                   Build();

                Eco.getEco().studentList.Add(student);


            }


            // this.studentRegistrationStudentTable.RowCount = userss.Count();

        }

        public int getRandomIndex()
        {
            Random random = new Random();
            int i = random.Next(0, 6);
            return random.Next(0, 6);
        }

        public int getRandomEnrolType()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }



    }
}
