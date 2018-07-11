using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    class NegativeCalculatorTests
    {
        [TestCase(6, -6)]
        [TestCase(-4, 4)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new NegativeCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
