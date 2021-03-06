﻿using System;
using NUnit.Framework;
using WFACalculate.OperationTwoArguments;

namespace WFACalculate.Tests.OperationTwoArguments
{
    class DivisionCalculatorTests
    {
        [TestCase(4, -2, -2)]
        [TestCase(20, 4, 5)]
        [TestCase(-10, -2, 5)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new DivisionCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(-10, 0)]
        public void ExceptionTest(double firstValue, double secondValue)
        {
            var calculator = new DivisionCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(firstValue, secondValue));
        }
    }
}
