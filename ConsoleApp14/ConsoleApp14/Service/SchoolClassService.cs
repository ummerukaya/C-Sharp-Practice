using ConsoleApp14.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Service
{
    public class SchoolClassService : ISchoolClassService
    {
        public List<SchoolClass> GetAllSchoolClasses()
        {
            var sql = "select * from SchoolClass";
            var reader = DataAdapter.DataAdapter.GetReader(sql);
            var classList = new List<SchoolClass>();
            while(reader.Read())
            {
                classList.Add(new SchoolClass()
                {
                    Id = Convert.ToInt32( reader["id"] ),
                    SectionId = Convert.ToInt32(reader["SectionId"]),
                    Classname = reader["Classname"].ToString(),
                    StartTime = Convert.ToDateTime(reader["StartTime"]),
                    EndTime = Convert.ToDateTime( reader["EndTime"] )
                });
            }
            return classList;
        }
    }
}
