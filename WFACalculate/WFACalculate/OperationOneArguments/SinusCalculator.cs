using System;

namespace WFACalculate.OperationOneArguments
{
    /// <summary>
    /// This class performs the function of the sine..
    /// </summary>
    public class SinusCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
