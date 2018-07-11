using System;

namespace WFACalculate.OperationOneArguments
{
    /// <summary>
    /// This class performs a number module.
    /// </summary>
    public class ModuleCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}
