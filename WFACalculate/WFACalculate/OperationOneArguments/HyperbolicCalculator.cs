using System;

namespace WFACalculate.OperationOneArguments
{
    /// <summary>
    /// This class performs an hyperbolic function (x is not equal to 0)
    /// </summary>
    public class HyperbolicCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0)
            {
                throw new Exception("Не существует");
            }
            return 1 / firstArgument;
        }
    }
}
