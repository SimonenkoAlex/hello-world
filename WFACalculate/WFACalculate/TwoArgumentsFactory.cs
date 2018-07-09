using System;

namespace WFACalculate
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "btnAdd": return new AdditionCalculator();
                case "btnMinus": return new SubtractionCalculator();
                case "btnMultiplication": return new MultiplyCalculator();
                case "btnDivision": return new DivisionCalculator();
                default: throw new Exception("Неизвестная операция");
            }
        }
    }
}
