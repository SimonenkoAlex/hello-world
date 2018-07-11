using System;
using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    class ExponentCalculatorTest
    {
        [TestCase(0, 1)]
        [TestCase(1, Math.E)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ExponentCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
