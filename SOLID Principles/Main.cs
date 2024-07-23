using System;
using CalculatorApp.Interfaces;
using CalculatorApp.Operations;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();

            Console.WriteLine("Enter the first number:");
            double op1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double op2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select operation: +, -, *, /");
            string operation = Console.ReadLine();

            IOperation operationInstance = null;

            switch (operation)
            {
                case "+":
                    operationInstance = new Addition();
                    break;
                case "-":
                    operationInstance = new Subtraction();
                    break;
                case "*":
                    operationInstance = new Multiplication();
                    break;
                case "/":
                    operationInstance = new Division();
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    return;
            }

            double result = calculator.PerformOperation(operationInstance, op1, op2);
            Console.WriteLine($"Result: {result}");
        }
    }
}
