using ConsoleApp14.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Class
{
    public class SchoolClass : BaseEntity
    {
        public string Classname { get; set; }
        public int SectionId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
