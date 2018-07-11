using System;

namespace WFACalculate.OperationOneArguments
{
    /// <summary>
    /// This class performs an exponent function
    /// </summary>
    public class ExponentCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}
