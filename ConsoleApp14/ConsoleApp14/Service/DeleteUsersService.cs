using ConsoleApp14.DataAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Service
{
    public class DeleteUsersService : IDeleteUsersService
    {
        public int DeleteUsers()
        {
            var sql = "delete from Users where Name='abc';";
            var write = DataAdapters.SetCommand(sql);
            int result = write.ExecuteNonQuery();
            return result;
        }
    }
}
