using ConsoleApp14.ControlFlows;
using ConsoleApp14.Factories;
using ConsoleApp14.Service;
using ConsoleApp14.GiveUserInput;
using System;

namespace ConsoleApp14
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserInput userInput = new UserInput();
            while (true)
            {
                userInput.GiveUserInput();
            }
        }
    }
}
