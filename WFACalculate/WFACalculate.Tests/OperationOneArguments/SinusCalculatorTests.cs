using  System;
using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    class SinusCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(Math.PI/2, 1)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new SinusCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
