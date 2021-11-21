using ConsoleApp14.ControlFlows;
using ConsoleApp14.Factories;
using ConsoleApp14.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.GiveUserInput
{
    public class UserInput
    {
        public void GiveUserInput()
        {
            Console.WriteLine("1. Class Time of all sections of all classes.\n" +
                "2. Assigned teachers on each section for each subject.\n"+
                "3. Add a row in users table.\n"+
                "4. Delete a row from users table.\n"+
                "5. Update a row from users table.");

            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                ISchoolClassFactory schoolClassFactory = new SchoolClassFactory();
                ISchoolClassService schoolClassService = new SchoolClassService();
                var obj = new MainControlFlow(schoolClassFactory, schoolClassService);
                obj.ShowAllClasses();
            }
            else if (a == 2)
            {
                ITeacherSectionFactory teacherSectionFactory = new TeacherSectionFactory();
                ITeacherSectionService teacherSectionService = new TeacherSectionService();
                var obj1 = new MainControlFlow(teacherSectionFactory, teacherSectionService);
                obj1.ShowAllTeachers();
            }
            else if (a == 3)
            {
                IInsertUsersService insertUsersService = new InsertUsersService();
                var obj2 = new MainControlFlow(insertUsersService);
                obj2.InsertNewUser();
            }
            else if (a == 4)
            {
                IDeleteUsersService deleteUsersService = new DeleteUsersService();
                var obj3 = new MainControlFlow(deleteUsersService);
                obj3.DeleteARow();
            }
            else if (a == 5)
            {
                IUpdateTableService updateTableService = new UpdateTableService();
                var obj4 = new MainControlFlow(updateTableService);
                obj4.UpdateARow();
            }
        }
    }
}
