using System;
using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    class ArcsineCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(1, Math.PI/2)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArcsineCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(-100)]
        [TestCase(200)]
        public void ExceptionTest(double firstValue)
        {
            var calculator = new ArcsineCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(firstValue));
        }
    }
}
