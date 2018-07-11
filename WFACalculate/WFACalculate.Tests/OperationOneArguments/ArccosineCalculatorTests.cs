using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    [TestFixture]
    class ArccosineCalculatorTests
    {
        [Test]
        public void CosineCalculatorTest()
        {
            ArccosineCalculator calculator = new ArccosineCalculator();
            Assert.AreEqual(0, calculator.Calculate(1));
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
