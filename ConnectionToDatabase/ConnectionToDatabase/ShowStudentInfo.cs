using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionToDatabase
{
    class ShowStudentInfo
    {
        public static void ShowAllStudentInfo()
        {
            IStudentData studentDataFactory = new StudentData();
            var result = studentDataFactory.PrepareAllStudentsData();

            Console.WriteLine(result);

        }
    }
}
