using NUnit.Framework;
using WFACalculate.OperationTwoArguments;

namespace WFACalculate.Tests.OperationTwoArguments
{
    class PowerxyCalculatorTests
    {
        [TestCase(6, 0, 1)]
        [TestCase(3, 4, 81)]
        [TestCase(-7, 2, 49)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new PowerxyCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
