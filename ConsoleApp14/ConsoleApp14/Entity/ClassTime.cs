
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14.Entity
{
    public class ClassTime:BaseEntity
    {
        public string StartFrom { get; set; }
        public string EndAt { get; set; }
        public int SubjectID { get; set; }
        public int ClassSectionID { get; set; }
    }
}
