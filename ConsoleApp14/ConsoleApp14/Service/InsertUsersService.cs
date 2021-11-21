using ConsoleApp14.DataAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Service
{
    public class InsertUsersService:IInsertUsersService
    {
        public int SetNewUsers()
        {
            var sql = "insert into Users(Name,Gender,DateOfBirth,PhoneNumber,email) values (@Name,@Gender,@DateOfBirth,@PhoneNumber,@email)";
            var write = DataAdapters.SetCommand(sql);
            //var data = 2;
            //for (int i = 0; i < data; i++)
            //{
            //    sql += "(@ID" + i.ToString() + ", @Name" + i.ToString() + ", @Gender" + i.ToString() + ", @DateOfBirth" + i.ToString() + 
            //        ", @PhoneNumber" + i.ToString() + ", @email" + i.ToString() + "),";
               // write.Parameters.AddWithValue("@ID",11);
                write.Parameters.AddWithValue("@Name","abc");
                write.Parameters.AddWithValue("@Gender", "Female");
                write.Parameters.AddWithValue("@DateOfBirth", "09/05/1999");
                write.Parameters.AddWithValue("@PhoneNumber", "000000000");
                write.Parameters.AddWithValue("@email", "abc@mmdd.com");
            //}
            //sql = sql.Remove(sql.Length - 1);
            int result = write.ExecuteNonQuery();
            return result;
        }

    }
}
