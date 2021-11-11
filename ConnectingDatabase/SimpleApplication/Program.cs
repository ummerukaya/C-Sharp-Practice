using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
//using ConnectionString;
//using ConnectSql;

namespace ConnectingDatabase
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Student student = new Student();

            //StringBuilder stringBuilder = new StringBuilder();
            //var query = Console.ReadLine();
            //stringBuilder.Append(query);
            //string sqlQuery = stringBuilder.ToString();
            //SqlConnectionClass.ExecuteSql(ConnectionStringClass.connectionString, sqlQuery,student);

            StudentClass.ShowAllStudentInfo();

        }
    }
}
