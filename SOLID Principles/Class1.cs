using CalculatorApp.Interfaces;

namespace CalculatorApp.Operations
{
    public class Addition : IOperation
    {
        public double Execute(double op1, double op2)
        {
            return op1 + op2;
        }
    }

    public class Subtraction : IOperation
    {
        public double Execute(double op1, double op2)
        {
            return op1 - op2;
        }
    }

    public class Multiplication : IOperation
    {
        public double Execute(double op1, double op2)
        {
            return op1 * op2;
        }
    }

    public class Division : IOperation
    {
        public double Execute(double op1, double op2)
        {
            if (op2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return op1 / op2;
        }
    }
}


namespace CalculatorApp
{
    public class Calculator : ICalculator
    {
        public double PerformOperation(IOperation operation, double op1, double op2)
        {
            return operation.Execute(op1, op2);
        }
    }
}

