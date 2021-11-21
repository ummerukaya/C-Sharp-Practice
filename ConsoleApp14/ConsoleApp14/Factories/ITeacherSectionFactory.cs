using ConsoleApp14.Entity;
using ConsoleApp14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Factories
{
    public interface ITeacherSectionFactory
    {
        List<TeacherSectionModel> PrepareAllTeacherSectionFactory(List<ClassTime> classtime);
    }
}
