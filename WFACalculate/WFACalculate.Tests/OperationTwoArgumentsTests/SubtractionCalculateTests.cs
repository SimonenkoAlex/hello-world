using NUnit.Framework;
using WFACalculate.OperationTwoArguments;

namespace WFACalculate.Tests.OperationTwoArgumentsTests
{
    class SubtractionCalculateTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, -1)]
        [TestCase(-7, -2, -5)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new SubtractionCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
