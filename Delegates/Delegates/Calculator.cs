using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class Calculator
    {
        public Action<int, int> Add = (firstNumber, secondNumber) => 
        Console.WriteLine(firstNumber + secondNumber);

        public Action<int, int> Subtract = (firstNumber, secondNumber) => 
        Console.WriteLine(firstNumber - secondNumber);

        public Action<int, int> Multiply = (firstNumber, secondNumber) => 
        Console.WriteLine(firstNumber * secondNumber);

        public Action<int, int> Division = (firstNumber, secondNumber) => 
        Console.WriteLine(firstNumber / secondNumber);
    }
}
