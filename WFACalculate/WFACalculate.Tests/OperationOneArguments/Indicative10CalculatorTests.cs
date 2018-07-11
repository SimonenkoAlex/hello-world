using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    class Indicative10CalculatorTests
    {
        [TestCase(1, 10)]
        [TestCase(3, 1000)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Indicative10Calculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
