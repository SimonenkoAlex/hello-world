using System;

namespace WFACalculate.OperationOneArguments
{
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
