using System;
using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    class ArccosineCalculatorTests
    {
        [TestCase(1, 0)]
        [TestCase(-1, Math.PI)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArccosineCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(-200)]
        [TestCase(100)]
        public void ExceptionTest(double firstValue)
        {
            var calculator = new ArccosineCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(firstValue));
        }
    }
}
