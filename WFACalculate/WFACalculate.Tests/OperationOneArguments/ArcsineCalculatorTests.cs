using System;
using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    [TestFixture]
    class ArcsineCalculatorTests
    {
        [Test]
        public void CosineCalculatorTest()
        {
            ArcsineCalculator calculator = new ArcsineCalculator();
            Assert.AreEqual(0, calculator.Calculate(0));
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
