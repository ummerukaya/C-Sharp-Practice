
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14.Entity
{
    public class UserRoleMapping:BaseEntity
    {
        public int UserID { get; set; }
        public int RoleID { get; set; }
    }
}
