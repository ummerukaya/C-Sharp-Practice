using ConsoleApp14.DataAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Service
{
    public class UpdateTableService : IUpdateTableService
    {
        public int UpdateTable()
        {
            var sql = "update Users set Name = @Name, email = @email Where Name = 'Saiful Islam';";
            var write = DataAdapters.SetCommand(sql);
            
            write.Parameters.AddWithValue("@Name", "Islam Saiful");
            write.Parameters.AddWithValue("@email", "saiful@gmail.com");
          
            int result = write.ExecuteNonQuery();
            return result;
        }
    }
}
