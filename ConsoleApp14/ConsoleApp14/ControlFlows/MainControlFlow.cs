using ConsoleApp14.Factories;
using ConsoleApp14.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class MainControlFlow
    {
        public static ISchoolClassFactory _schoolClassFactory;
        private readonly ISchoolClassService _schoolClassService;

        public MainControlFlow(ISchoolClassFactory schoolClassFactory,
                           ISchoolClassService schoolClassService)
        {
            _schoolClassFactory = schoolClassFactory;
            _schoolClassService = schoolClassService;
        }
        public  void ShowAllClasses()
        {
            var classes = _schoolClassService.GetAllSchoolClasses();
            var models = _schoolClassFactory.PrepareAllClassesFactory(classes);

            foreach (var model in models)
            {
                // do with reflection instead of console writeline
                Console.WriteLine(" Id " + model.Id);
                Console.WriteLine("Sec name "+ model.SectionName);
                Console.WriteLine("Start from " + model.StartFrom);
                Console.WriteLine("end at " + model.EndAt);
                Console.WriteLine("sub name " + model.SubjectName);
                
            }

        }
    }
}
