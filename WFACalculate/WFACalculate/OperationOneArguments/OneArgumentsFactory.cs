using System;

namespace WFACalculate.OperationOneArguments
{
    public static class OneArgumentsFactory
    {
        /// <summary>
        /// This is a static class-factory, which is responsible for creating instances of calculators by their name.
        /// </summary>
        /// <param name="calculatorName"> Names of one-argument operations. </param>
        /// <returns> Return copies of calculators. </returns>
        public static IOneArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sinus": return new SinusCalculator();
                case "Cosine": return new CosineCalculator();
                case "Logarithm": return new LogarithmCalculator();
                case "Power": return new PowerCalculator();
                case "Tangent": return new TangentCalculator();
                case "Arcsine": return new ArcsineCalculator();
                case "Arccosine": return new ArccosineCalculator();
                case "Arctangent": return new ArctangentCalculator();
                case "Exponent": return new ExponentCalculator();
                case "Indicative": return new IndicativeCalculator();
                case "Log10": return new Log10Calculator();
                case "Module": return new ModuleCalculator();
                case "Negative": return new NegativeCalculator();
                case "Hyperbolic": return new HyperbolicCalculator();
                case "Indicative10": return new Indicative10Calculator();
                default: throw new Exception("Неизвестная операция");
            }
        }
    }
}
