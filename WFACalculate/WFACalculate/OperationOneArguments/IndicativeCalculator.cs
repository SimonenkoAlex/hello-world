using System;

namespace WFACalculate.OperationOneArguments
{
    /// <summary>
    /// This class performs an exponential function with base 2.
    /// </summary>
    public class IndicativeCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(2, firstArgument);
        }
    }
}
