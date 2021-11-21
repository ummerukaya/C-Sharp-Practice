using ConsoleApp14.DataAdapter;
using ConsoleApp14.Entity;
using ConsoleApp14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Factories
{
    public class TeacherSectionFactory : ITeacherSectionFactory
    {
        public List<TeacherSectionModel> PrepareAllTeacherSectionFactory(List<ClassTime> classtime)
        {
            var ids = "";

            for (int i = 0; i < classtime.Count - 1; i++)
            {
                ids += classtime[i].ID + ",";
            }
            ids += classtime[classtime.Count - 1].ID;


            var sql1 = @"select ct.ID,uctm.UserID,u.Name,sb.Name as SubjectName,csm.ClassID,s.Name as SectionName from ClassTime ct 
                            inner join ClassSectionMapping csm on csm.ID=ct.ClassSectionID
                            inner join Section s on csm.SectionID=s.ID
                            inner join [Subject] sb on ct.SubjectID=sb.ID
                            inner join UserClassTimeMapping uctm on ct.ID=uctm.ClassTimeID
                            inner join Users u on u.ID=uctm.UserID
                            where ct.ID in (" + ids + ");";

            var reader = DataAdapters.GetReader(sql1);

            var models = new List<TeacherSectionModel>();
            while (reader.Read())
            {
                models.Add(new TeacherSectionModel()
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    UserID = Convert.ToInt32(reader["UserID"]),
                    Name = reader["Name"].ToString(),
                    SubjectName = reader["SubjectName"].ToString(),
                    ClassID = Convert.ToInt32(reader["ClassID"]),
                    SectionName = reader["SectionName"].ToString()
                });
            }
            return models;
        }

    }
}
