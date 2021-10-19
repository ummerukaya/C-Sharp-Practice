using System;

namespace AccessModifiers
{
    class Test
    {
        private string _privateVariable = "Private Variable";
        public string _name="Public Variable";
        public void Msg()
        {
            Console.WriteLine(_privateVariable);
            Console.Write("My name is ");
        }

        protected string _name1 = "Protected Variable";
        protected virtual void Msg1()
        {
            Console.WriteLine("Hello " + _name1);
        }

        internal string _name3 = "Internal Variable";
        internal void InternalMethod()
        {
            Console.Write("My name is ");
        }
    }

    class Test2 : Test
    {
        public void Msg2()
        {
            Console.WriteLine(_name1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test1 = new Test();
            test1.Msg();
            Console.WriteLine(test1._name);

            Test2 test2 = new Test2();
            test2.Msg2();

            test1.InternalMethod();
            Console.WriteLine(test1._name3);
        }
    }
}
