using System;
using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    class HyperbolicCalculatorTests
    {
        [TestCase(4, 0.25)]
        [TestCase(1, 1)]
        [TestCase(-10, -0.1)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new HyperbolicCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(0)]
        public void ExceptionTest(double firstValue)
        {
            var calculator = new HyperbolicCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(firstValue));
        }
    }
}
