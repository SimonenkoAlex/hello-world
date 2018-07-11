using System;

namespace WFACalculate.OperationTwoArguments
{
    /// <summary>
    /// This class performs the construction of the argument x to the power of y.
    /// </summary>
    public class PowerxyCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
