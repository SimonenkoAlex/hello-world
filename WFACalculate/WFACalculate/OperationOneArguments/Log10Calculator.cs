using System;

namespace WFACalculate.OperationOneArguments
{
    /// <summary>
    /// This class performs a base 10 logarithm.
    /// </summary>
    public class Log10Calculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new Exception("Не существует");
            }
            return Math.Log10(firstArgument);
        }
    }
}
