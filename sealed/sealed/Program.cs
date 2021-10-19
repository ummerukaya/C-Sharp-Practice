using System;

namespace Sealed
{

    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Grass");
        }
    }

    public class Cow : Animal
    {
        public sealed override void Eat()
        {
            Console.WriteLine("green grass");
        }
    }

    sealed public class BabyCow : Cow
    {
        /*public override void Eat() //sealed method cannot be overriden //build error
        {
            Console.WriteLine("no grass");
        }*/
    }

    class Program
{
    static void Main(string[] args)
    {
            Animal animal = new Cow();
            animal.Eat();
    }
}
}
