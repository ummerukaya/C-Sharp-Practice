using ConnectSql;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConnectionToDatabase
{
    public class StudentData : IStudentData
    {
       

        public string PrepareAllStudentsData()
        {
            var sql = "select * from Student;";
            var reader = DbReader.GetReader(sql);
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                students.Add(new Student()
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Section = reader["Section"].ToString(),
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                    Address = reader["Address"].ToString(),
                    Phone = reader["Phone"].ToString(),

                });
            }

           

            var resultString = "";
            
            foreach (var student in students)
            {
                var str1 = student.GetType().GetProperties();
                
                for(int i = 0; i < str1.Length; i++)
                {
                    var str = str1[i].GetValue(student, null);
                    
                    resultString += str+" ";
                }
                resultString += '\n';
                
            }
            return resultString;
            
        }
    }
}
