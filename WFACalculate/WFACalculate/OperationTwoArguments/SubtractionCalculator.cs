namespace WFACalculate.OperationTwoArguments
{
    /// <summary>
    /// This class performs the subtraction of two arguments.
    /// </summary>
    public class SubtractionCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
