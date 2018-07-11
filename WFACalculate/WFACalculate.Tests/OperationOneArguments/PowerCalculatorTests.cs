using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArgumentsTests
{
    class PowerCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(3, 9)]
        [TestCase(-7, 49)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new PowerCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
