//using ConnectionString;
//using ConnectSql;

namespace ConnectionToDatabase
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

            ShowStudentInfo.ShowAllStudentInfo();

        }
    }
}