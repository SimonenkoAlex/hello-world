using System;

namespace WFACalculate.OperationOneArguments
{
    /// <summary>
    /// This class performs the function of the tangent.
    /// </summary>
    public class TangentCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}
