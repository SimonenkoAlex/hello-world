using System;

namespace WFACalculate.OperationTwoArguments
{
    public static class TwoArgumentsFactory
    {
        /// <summary>
        /// This is a static class-factory, which is responsible for creating instances of calculators by their name.
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns></returns>
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Addition": return new AdditionCalculator();
                case "Subtraction": return new SubtractionCalculator();
                case "Multiplication": return new MultiplyCalculator();
                case "Division": return new DivisionCalculator();
                case "Powerxy": return new PowerxyCalculator();
                default: throw new Exception("Неизвестная операция");
            }
        }
    }
}
