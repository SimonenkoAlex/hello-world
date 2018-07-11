using System;

namespace WFACalculate.OperationOneArguments
{
    /// <summary>
    /// This class performs an exponential function with base 10.
    /// </summary>
    public class Indicative10Calculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(10, firstArgument);
        }
    }
}
