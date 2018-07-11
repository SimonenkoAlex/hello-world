using System;

namespace WFACalculate.OperationOneArguments
{
    /// <summary>
    /// This class performs the natural logarithm (if x not negative).
    /// </summary>
    public class LogarithmCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new Exception("Не существует");
            }
            return Math.Log(firstArgument);
        }
    }
}
