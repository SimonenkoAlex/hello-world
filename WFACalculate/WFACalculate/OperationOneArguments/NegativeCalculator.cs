namespace WFACalculate.OperationOneArguments
{
    /// <summary>
    /// This class changes the sign of a number.
    /// </summary>
    public class NegativeCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return firstArgument * (-1);
        }
    }
}
