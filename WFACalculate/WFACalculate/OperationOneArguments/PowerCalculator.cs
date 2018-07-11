using System;

namespace WFACalculate.OperationOneArguments
{
    /// <summary>
    /// This class performs a quadratic function.
    /// </summary>
    public class PowerCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);
        }
    }
}
