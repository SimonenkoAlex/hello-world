using System;

namespace WFACalculate.OperationTwoArguments
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Addition": return new AdditionCalculator();
                case "Subtraction": return new SubtractionCalculator();
                case "Multiplication": return new MultiplyCalculator();
                case "Division": return new DivisionCalculator();
                default: throw new Exception("Неизвестная операция");
            }
        }
    }
}
