using System;
namespace CallByValueAndReferenceTest
{
    class Program
    { 
        public void ByValue(int val)
        {
            val *= val;   
            Console.WriteLine("Value inside the called ByValue function= " + val); 
        }

        public void ByReference(ref int val)
        {
            val *= val;
            Console.WriteLine("Value inside the called ByReference function= " + val);
        }

        static void Main(string[] args)
        {
            int val = 5;
            Program Value = new Program();  
            Console.WriteLine("Value before calling = " + val);

            Value.ByValue(val);  //called by value           
            Console.WriteLine("Value after calling ByValue = " + val);

            Program Value2 = new Program();
            Value.ByReference(ref val);  //called by reference          
            Console.WriteLine("Value after calling ByReference = " + val);

        }
    }
}