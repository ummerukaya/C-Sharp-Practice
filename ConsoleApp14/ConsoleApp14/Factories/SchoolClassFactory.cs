using ConsoleApp14.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp14.DataAdapter;
using ConsoleApp14.Models;

namespace ConsoleApp14.Factories
{
    public class SchoolClassFactory : ISchoolClassFactory
    {
        public List<SchoolClassModel> PrepareAllClassesFactory(List<SchoolClass> classes)
        {
            var ids = "";

            for(int i=0;i<classes.Count-1;i++)
            {
                ids += classes[i] + ",";
            }
            ids += classes[classes.Count - 1];

            var sql = @"select c.ID,ct.StartFrom,ct.EndAt,s.Name,sb.Name from Class c
                        inner join ClassSectionMapping csm on csm.ClassID=c.ID
                        inner join Section s on s.ID= csm.SectionID
                        inner join ClassTime ct on ct.ClassSectionID= csm.ID
                        inner join [Subject] sb on sb.ID= ct.SubjectID
                        where c.Id in ("+ids+");";
            var reader = DataAdapter.DataAdapter.GetReader(sql);

            var models = new List<SchoolClassModel>();
            while (reader.Read())
            {
                models.Add(new SchoolClassModel()
                {
                    Id = Convert.ToInt32( reader["id"] ),
                    SubjectName = reader["SubjectName"].ToString(),
                    SectionName = reader["SectionName"].ToString(),
                    StartFrom = Convert.ToDateTime( reader["StartFrom"] ),
                    EndAt = Convert.ToDateTime(reader["EndAt"])
                });
            }
            return models;
        }

        
    }
}
