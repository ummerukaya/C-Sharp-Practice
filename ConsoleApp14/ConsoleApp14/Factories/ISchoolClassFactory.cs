using ConsoleApp14.Class;
using ConsoleApp14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Factories
{
    public interface ISchoolClassFactory
    {
        List<SchoolClassModel> PrepareAllClassesFactory(List<SchoolClass> classes);
    }
}
