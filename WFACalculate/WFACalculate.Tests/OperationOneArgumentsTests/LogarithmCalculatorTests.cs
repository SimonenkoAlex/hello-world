using System;
using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArgumentsTests
{
    class LogarithmCalculatorTests
    {
        [TestCase(1, 0)]
        [TestCase(Math.E, 1)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new LogarithmCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
