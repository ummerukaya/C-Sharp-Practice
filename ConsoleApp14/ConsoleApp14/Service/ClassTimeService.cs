using ConsoleApp14.DataAdapter;
using ConsoleApp14.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Service
{
    public class ClassTimeService:IClassTimeService
    {
        public List<ClassTime> GetAllClassTime()
        {
            var sql = "select * from ClassTime;";
            var reader = DataAdapters.GetReader(sql);
            var classTimeList = new List<ClassTime>();
            while (reader.Read())
            {
                classTimeList.Add(new ClassTime()
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    SubjectID = Convert.ToInt32(reader["SubjectID"]),
                    ClassSectionID = Convert.ToInt32(reader["ClassSectionID"]),
                    StartFrom = reader["StartFrom"].ToString(),
                    EndAt = reader["EndAt"].ToString()
                });
            }
            reader.Close();
            return classTimeList;
        }
    }
}
