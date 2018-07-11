using System;

namespace WFACalculate.OperationOneArguments
{
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
