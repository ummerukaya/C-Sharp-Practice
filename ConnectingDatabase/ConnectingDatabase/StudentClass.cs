using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectingDatabase
{
    public class StudentClass
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public static void ShowAllStudentInfo()
        {
            IStudentDataFactory studentDataFactory = new StudentDataFactory();
            var result = studentDataFactory.PrepareAllStudentsData();

            Console.WriteLine(result);

        }
    }
}
