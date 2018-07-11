using System;

namespace WFACalculate.OperationOneArguments
{
    public class Indicative10Calculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(10, firstArgument);
        }
    }
}
