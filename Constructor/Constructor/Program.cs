using System;

namespace Constructor
{
    class Coords
    {
        public Coords() : this(0, 0)
        {

        }
        public Coords(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Coords();
            Console.WriteLine(p1);

            var p2 = new Coords(5, 3);
            Console.WriteLine(p2);
        }
    }
}
