using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    class IndicativeCalculatorTests
    {
        [TestCase(1, 2)]
        [TestCase(3, 8)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new IndicativeCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
