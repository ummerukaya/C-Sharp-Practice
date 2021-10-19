using System;

namespace Generic
{
    class AClass<T> //generic class //T is the placeholder
    {
        T _number;
        public AClass(T number)
        {
            this._number = number;
        }

        public T GetValue()
        {
            return _number;
        }
    }

    class ANonGenericClass
    {
        public void GenericMethod<T>(T msg) //generic method
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AClass<int> IntNumber = new AClass<int>(20);
            Console.WriteLine(IntNumber.GetValue());
            AClass<string> StringNumber = new AClass<string>("suny");
            Console.WriteLine(StringNumber.GetValue());
            //here we can use one class for objects of different types

            ANonGenericClass example = new ANonGenericClass();
            example.GenericMethod<int>(20);
            example.GenericMethod<string>("THis is a string");

        }
    }
}
