using ConsoleApp14.Factories;
using ConsoleApp14.Service;
using ConsoleApp14.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.ControlFlows
{
    public class MainControlFlow
    {
        public static ISchoolClassFactory _schoolClassFactory;
        public static ISchoolClassService _schoolClassService;
        public static ITeacherSectionFactory _teacherSectionFactory;
        public static ITeacherSectionService _teacherSectionService;
        private IInsertUsersService _insertUsersService;
        private IDeleteUsersService _deleteUsersService;
        private IUpdateTableService _updateTableService;

        public MainControlFlow(IInsertUsersService insertUsersService)
        {
            _insertUsersService = insertUsersService;
        }

        public MainControlFlow(ISchoolClassFactory schoolClassFactory,
                           ISchoolClassService schoolClassService)
        {
            _schoolClassFactory = schoolClassFactory;
            _schoolClassService = schoolClassService;
        }

        public MainControlFlow(ITeacherSectionFactory teacherSectionFactory,
            ITeacherSectionService teacherSectionService)
        {
            _teacherSectionFactory = teacherSectionFactory;
            _teacherSectionService = teacherSectionService;
        }

        public MainControlFlow(IDeleteUsersService deleteUsersService)
        {
            _deleteUsersService = deleteUsersService;
        }

        public MainControlFlow(IUpdateTableService updateTableService)
        {
            _updateTableService = updateTableService;
        }

        public void DeleteARow()
        {
            var rowDeleted = _deleteUsersService.DeleteUsers();

            Console.WriteLine("Number of row deleted from table " + rowDeleted);
        }

        public  void ShowAllClasses()
        {
            var classes = _schoolClassService.GetAllSchoolClasses();
            var models = _schoolClassFactory.PrepareAllClassesFactory(classes);

            foreach (var model in models)
            {
                // do with reflection instead of console writeline
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

        public void UpdateARow()
        {
            var rowUpdated = _updateTableService.UpdateTable();

            Console.WriteLine("Number of row updated from table " + rowUpdated);
        }

        public void ShowAllTeachers()
        {
            var classtime = _teacherSectionService.GetAllClassTime();
            var models = _teacherSectionFactory.PrepareAllTeacherSectionFactory(classtime);

            foreach (var model in models)
            {
                // do with reflection instead of console writeline
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
        public void InsertNewUser()
        {
            var rowAffected = _insertUsersService.SetNewUsers();
            
            Console.WriteLine("Number of row added in table "+rowAffected);

        }
    }
}
