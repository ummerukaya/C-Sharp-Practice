using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotation
{
    class DataAnnotationClass
    {
        public string Name { get; set; }


    }
    class Program
    {
        public static void T1(int x)
        {
            x = 10;
        }
        public static void T2(DataAnnotationClass x)
        {
            x.Name = "ABC";
        }
        static void Main(string[] args)
        {
            DataAnnotationClass obj = new DataAnnotationClass();
            int x = 15;
            obj.Name = "suny";
            T1(x);
            T2(obj);
            Console.WriteLine(x);
            Console.WriteLine(obj.Name);
        }
    }
}
