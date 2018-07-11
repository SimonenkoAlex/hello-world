namespace WFACalculate.OperationTwoArguments
{
    /// <summary>
    /// This class performs multiplication of two arguments.
    /// </summary>
    public class MultiplyCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
