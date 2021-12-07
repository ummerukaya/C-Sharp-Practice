using System;

namespace Delegates
{
    // defining delegate
    public delegate void CalculatorHandler(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            var calculate = new CalculatorHandler(calculator.Add);
            calculate += new CalculatorHandler(calculator.Subtract);
            calculate += new CalculatorHandler(calculator.Multiply);
            calculate += new CalculatorHandler(calculator.Division);
            calculate.Invoke(2, 3);
        }
       
    }
}
