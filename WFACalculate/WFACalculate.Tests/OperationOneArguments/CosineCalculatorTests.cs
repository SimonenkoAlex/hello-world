﻿using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    [TestFixture]
    class CosineCalculatorTests
    {
        [Test]
        public void CosineCalculatorTest()
        {
            CosineCalculator calculator = new CosineCalculator();
            Assert.AreEqual(1, calculator.Calculate(0));
        }
    }
}
