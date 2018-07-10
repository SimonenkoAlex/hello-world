using System;

namespace WFACalculate.OperationOneArguments
{
    public class LogarithmCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}
