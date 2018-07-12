using System;

namespace WFACalculate.OperationOneArguments
{
    public class ArccosineCalculator: IOneArgumentsCalculator
    {
        /// <summary>
        /// This class performs an arccosine function on (-1; 1).
        /// </summary>
        /// <param name="firstArgument"> Real argument </param>
        /// <returns> Return a real result </returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument < -1 || firstArgument > 1)
            {
                throw new Exception("Не существует");
            }
            return Math.Acos(firstArgument);
        }
    }
}
