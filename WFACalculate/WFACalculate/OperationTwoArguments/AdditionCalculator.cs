namespace WFACalculate.OperationTwoArguments
{
    /// <summary>
    /// This class performs the addition of two arguments.
    /// </summary>
    public class AdditionCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
