using ConsoleApp14.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Service
{
    public interface IUsersService
    {
        void AddNewUsers(Users users);
        void DeleteFromUsers(Users users);
        void UpdateUsers(Users users);
    }
}
