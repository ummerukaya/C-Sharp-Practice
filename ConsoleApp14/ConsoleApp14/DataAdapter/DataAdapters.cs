using ConnectionString;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ConsoleApp14.Entity;


namespace ConsoleApp14.DataAdapter
{
    public class DataAdapters
    {
        public static SqlDataReader GetReader(string sqlQuery)
        {

            SqlConnection conn = new SqlConnection(ConnectionStringClass.connectionString);

            conn.Open();
           
            SqlCommand command = new SqlCommand(sqlQuery, conn);

            var reader = command.ExecuteReader();

            return reader;
             
        }
        public static SqlCommand SetCommand(string sqlQuery)
        {

            SqlConnection conn = new SqlConnection(ConnectionStringClass.connectionString);
            conn.Open();
            SqlCommand command = new SqlCommand(sqlQuery, conn);
            var writer = command;
            return writer;

        }
    }
}
