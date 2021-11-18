using ConsoleApp14.Factories;
using ConsoleApp14.Service;
using System;

namespace ConsoleApp14
{
    class Program
    {
        public static void GiveUserInput()
        {
            Console.WriteLine("give input");
            int a = Convert.ToInt32( Console.ReadLine() );

            if(a==1)
            {
                ISchoolClassFactory schoolClassFactory = new SchoolClassFactory();
                ISchoolClassService schoolClassService = new SchoolClassService();
                var obj = new  MainControlFlow(schoolClassFactory, schoolClassService);
                obj.ShowAllClasses();
            }

        }
        public static void Main(string[] args)
        {
            GiveUserInput();
        }
    }
}
