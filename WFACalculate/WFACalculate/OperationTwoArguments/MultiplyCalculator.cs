using WFACalculate.OperationTwoArguments;

namespace WFACalculate
{
    public class MultiplyCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
