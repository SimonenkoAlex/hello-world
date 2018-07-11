using System;

namespace WFACalculate.OperationOneArguments
{
    public class ModuleCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}
