using System;

namespace WFACalculate.OperationOneArguments
{
    public class ExponentCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}
