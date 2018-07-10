using System;

namespace WFACalculate
{
    public class SinusCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
