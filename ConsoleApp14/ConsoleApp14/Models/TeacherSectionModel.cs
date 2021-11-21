using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Models
{
    public class TeacherSectionModel:BaseModel
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string SubjectName { get; set; }
        public int ClassID { get; set; }
        public string SectionName { get; set; }
    }
}
