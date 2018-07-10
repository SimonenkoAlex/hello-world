using System;

namespace WFACalculate.OperationOneArguments
{
    public class CosineCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
