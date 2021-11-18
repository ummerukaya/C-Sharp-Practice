using ConsoleApp14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Models
{
    public class SchoolClassModel : BaseModel
    {
        public string SectionName { get; set; }
        public string SubjectName { get; set; }
        public DateTime StartFrom { get; set; }
        public DateTime EndAt { get; set; }
    }
}
