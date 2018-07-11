using System;

namespace WFACalculate.OperationOneArguments
{
    /// <summary>
    /// This class performs an arctangent function
    /// </summary>
    public class ArctangentCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}
