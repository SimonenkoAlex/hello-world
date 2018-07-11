using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    class Log10CalculatorTests
    {
        [TestCase(1, 0)]
        [TestCase(10, 1)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Log10Calculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
