using ConnectionString;
using System;
using System.Data.SqlClient;

namespace ConnectSql
{
    public class DbReader
    {
        public static SqlDataReader GetReader(string sqlQuery)
        {

            SqlConnection conn = new SqlConnection(ConnectionStringClass.connectionString);

            conn.Open();
            Console.WriteLine("successful");
            SqlCommand command = new SqlCommand(sqlQuery, conn);
            var reader = command.ExecuteReader();

            return reader;
            // conn?.Close();    
        }

    }
}