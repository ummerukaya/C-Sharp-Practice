using ConsoleApp14.DataAdapter;
using ConsoleApp14.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Service
{
    public class UsersService:IUsersService
    {

        public void AddNewUsers(Users users)
        {
            var sql = "insert into Users(Name,Gender,DateOfBirth,PhoneNumber,email) values (@Name,@Gender,@DateOfBirth,@PhoneNumber,@email)";
            var write = DataAdapters.SetCommand(sql);
            write.Parameters.AddWithValue("@Name", users.Name);
            write.Parameters.AddWithValue("@Gender", users.Gender);
            write.Parameters.AddWithValue("@DateOfBirth", users.DateOfBirth);
            write.Parameters.AddWithValue("@PhoneNumber", users.PhoneNumber);
            write.Parameters.AddWithValue("@email", users.Email);
            write.ExecuteNonQuery();
        }
        public void DeleteFromUsers(Users users)
        {
            if (users.Name==null)
            {
                throw new ValidationException("Error.");
            }
            var sql = @"delete from Users where Name='" + users.Name + "';";
           var write = DataAdapters.SetCommand(sql);
           write.ExecuteNonQuery();         
        }

        public void UpdateUsers(Users users)
        {
            if (users.Name == null)
            {
                throw new ValidationException("Error.");
            }
            var sql = "update Users set Name = @Name, email = @email Where Name ='" + users.Name + "';";
           var write = DataAdapters.SetCommand(sql);
           write.Parameters.AddWithValue("@Name", "Islam Saiful");
           write.Parameters.AddWithValue("@Gender","Male");
           write.Parameters.AddWithValue("@email", "saiful@gmail.com");
           write.ExecuteNonQuery();
        }
       
    }
}
