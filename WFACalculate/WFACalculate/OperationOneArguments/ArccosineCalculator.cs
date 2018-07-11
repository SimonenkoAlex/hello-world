using System;

namespace WFACalculate.OperationOneArguments
{
    public class ArccosineCalculator: IOneArgumentsCalculator
    {
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
