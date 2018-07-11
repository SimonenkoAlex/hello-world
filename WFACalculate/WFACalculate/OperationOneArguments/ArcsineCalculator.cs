using System;

namespace WFACalculate.OperationOneArguments
{
    /// <summary>
    /// This class performs an arcsine function on (-1; 1)
    /// </summary>
    public class ArcsineCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < -1 || firstArgument > 1)
            {
                throw new Exception("Не существует");
            }
            return Math.Asin(firstArgument);
        }
    }
}
