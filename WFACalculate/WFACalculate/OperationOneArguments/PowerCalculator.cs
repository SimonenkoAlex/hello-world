using System;

namespace WFACalculate.OperationOneArguments
{
    public class PowerCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);
        }
    }
}
