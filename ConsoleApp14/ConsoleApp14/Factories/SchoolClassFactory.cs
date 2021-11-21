using ConsoleApp14.Entity;
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
                ids += classes[i].ID + ",";
            }
            ids += classes[classes.Count - 1].ID;
            

            var sql1 = @"select c.ID,ct.StartFrom,ct.EndAt,s.Name,sb.Name as SubjectName from SchoolClass c
                        inner join ClassSectionMapping csm on csm.ClassID=c.ID
                        inner join Section s on s.ID= csm.SectionID
                        inner join ClassTime ct on ct.ClassSectionID= csm.ID
                        inner join [Subject] sb on sb.ID= ct.SubjectID
                        where c.ID in ("+ids+");";

            var reader = DataAdapters.GetReader(sql1);

            var models = new List<SchoolClassModel>();
            while (reader.Read())
            {
                models.Add(new SchoolClassModel()
                {
                    ID = Convert.ToInt32( reader["ID"] ),
                    SubjectName = reader["SubjectName"].ToString(),
                    SectionName = reader["Name"].ToString(),
                    StartFrom = reader["StartFrom"].ToString(),
                    EndAt = reader["EndAt"].ToString()
                });
            }
            return models;
        }

        
    }
}
