using System;

namespace WFACalculate.OperationOneArguments
{
    public static class OneArgumentsFactory
    {
        public static IOneArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sinus": return new SinusCalculator();
                case "Cosine": return new CosineCalculator();
                case "Logarithm": return new LogarithmCalculator();
                case "Power": return new PowerCalculator();
                default: throw new Exception("Неизвестная операция");
            }
        }
    }
}
