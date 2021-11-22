using ConsoleApp14.Entity;
using ConsoleApp14.Factories;
using ConsoleApp14.Service;
using System;

namespace ConsoleApp14.ControlFlows
{
    public class MainControlFlow
    {
        public static ISchoolClassFactory _schoolClassFactory;
        public static ISchoolClassService _schoolClassService;
        public static ITeacherSectionFactory _teacherSectionFactory;
        public static IClassTimeService _teacherSectionService;
  

        public MainControlFlow(ISchoolClassFactory schoolClassFactory,
                           ISchoolClassService schoolClassService)
        {
            _schoolClassFactory = schoolClassFactory;
            _schoolClassService = schoolClassService;
        }

        public MainControlFlow(ITeacherSectionFactory teacherSectionFactory,
            IClassTimeService teacherSectionService)
        {
            _teacherSectionFactory = teacherSectionFactory;
            _teacherSectionService = teacherSectionService;
        }


        public void ShowAllClasses()
        {
            var classes = _schoolClassService.GetAllSchoolClasses();
            var models = _schoolClassFactory.PrepareAllClassesFactory(classes);

            foreach (var model in models)
            {
                var allData = "";
                var str1 = model.GetType().GetProperties();
                for (int i = 0; i < str1.Length; i++)
                {
                    var str = str1[i].GetValue(model);
                    allData += str + " ";
                }
                Console.WriteLine(allData);

            }

        }

        
        public void ShowAllTeachers()
        {
            var classtime = _teacherSectionService.GetAllClassTime();
            var models = _teacherSectionFactory.PrepareAllTeacherSectionFactory(classtime);

            foreach (var model in models)
            {
                var allData = "";
                var str1 = model.GetType().GetProperties();
                for (int i = 0; i < str1.Length; i++)
                {
                    var str = str1[i].GetValue(model);
                    allData += str + " ";
                }
                Console.WriteLine(allData);

            }

        }
       
    }
}
