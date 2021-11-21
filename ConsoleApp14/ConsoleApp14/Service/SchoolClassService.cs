using ConsoleApp14.DataAdapter;
using ConsoleApp14.Entity;
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
            var sql = "select * from SchoolClass;";
            var reader = DataAdapters.GetReader(sql);
            var classList = new List<SchoolClass>();
            while(reader.Read())
            {
                classList.Add(new SchoolClass()
                {
                    ID = Convert.ToInt32( reader["ID"] ),
                    StartFrom = Convert.ToDateTime(reader["StartFrom"]),
                    EndTo = Convert.ToDateTime( reader["EndTo"] )
                });
            }
            return classList;
        }
    }
}
