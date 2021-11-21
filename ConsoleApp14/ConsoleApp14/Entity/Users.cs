
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14.Entity
{
    public class Users:BaseEntity
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
