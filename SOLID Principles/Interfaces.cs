namespace CalculatorApp.Interfaces
{
    public interface IOperation
    {
        double Execute(double op1, double op2);
    }

    public interface ICalculator
    {
        double PerformOperation(IOperation operation, double op1, double op2);
    }
}
