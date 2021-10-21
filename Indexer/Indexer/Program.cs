using System;

namespace Indexer
{
    class CustomIndexerClass   //class for custom indexer
    {
        private string[] num = new string[5];
        public string this[int ind]
        {
            get
            {
                if (ind < 0 || ind >= num.Length)
                    throw new IndexOutOfRangeException("out of range");
                return num[ind];
            }
            set
            {
                if (ind < 0 || ind >= num.Length)
                    throw new IndexOutOfRangeException("out of range");
                num[ind] = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    class GenericIndexerClass<T>   //class for generic indexer
    {
        private T[] roll;

        public GenericIndexerClass(int length)
        {
            roll = new T[length];
        }
        public T this[int ind]
        {
            get
            {
                return roll[ind];
            }
            set
            {
                roll[ind] = value;
            }
        }
    }

    class OverloadIndexerClass   //class for overload indexer
    {
        private int[] id = new int[5];
        private string[] section = new string[5];
        public int this[int ind]
        {
            get
            { 
                return id[ind];
            }
            set
            {
                id[ind] = value;
            }
        }
        public string this[char ind1]
        {
            get
            {
                return section[ind1];
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomIndexerClass number = new CustomIndexerClass();
            for (int i = 0; i < 5; i++)
            {
                number[i] = Console.ReadLine();
            }


            number.Name = "suny";
            Console.WriteLine(number.Name);
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(number[i]);
            }

            GenericIndexerClass<int> number1 = new GenericIndexerClass<int>(5);
            for(int i = 0; i < 5; i++)
            {
                number1[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(number.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(number1[i]);
            }

            GenericIndexerClass<string> name = new GenericIndexerClass<string>(10);
            for (int i = 0; i < 10; i++)
            {
                name[i] = Console.ReadLine();
            }

            Console.WriteLine(number.Name);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(name[i]);
            }

            OverloadIndexerClass over = new OverloadIndexerClass();
            for (int i = 0; i < 5; i++)
            {
                over[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(number.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(over[i]);
            }

        }
    }
}
