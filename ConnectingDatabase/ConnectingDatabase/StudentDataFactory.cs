using ConnectSql;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectingDatabase
{
    public class StudentDataFactory : IStudentDataFactory
    {

        public string PrepareAllStudentsData()
        {
            var sql = "select * from Student;";
            var reader = DbReader.GetReader(sql);
            var students = new List<StudentClass>();
            while (reader.Read())
            {
                students.Add(new StudentClass()
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    FirstName = reader["firstName"].ToString(),
                    SecondName = reader["secondName"].ToString(),

                });
            }
            
            var resultString = "";

            foreach (var student in students)
            {
                var str = student.Id;
                var str1= student.FirstName;
                var str2 = student.SecondName;
                resultString = resultString + str+" "+str1+" "+str2+"\n";
            }
            return resultString;
        }
    }
}
