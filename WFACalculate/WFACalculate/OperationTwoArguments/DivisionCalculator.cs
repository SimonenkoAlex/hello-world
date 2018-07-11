using System;

namespace WFACalculate.OperationTwoArguments
{
    /// <summary>
    /// This class performs a division of the two arguments (x is not equal to 0).
    /// </summary>
    public class DivisionCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0 невозможно");
            }
            return firstArgument / secondArgument;
        }
    }
}
