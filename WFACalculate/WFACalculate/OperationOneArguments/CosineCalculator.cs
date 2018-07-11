using System;

namespace WFACalculate.OperationOneArguments
{
    /// <summary>
    /// This class performs an cosine function
    /// </summary>
    public class CosineCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
