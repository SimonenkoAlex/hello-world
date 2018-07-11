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
    class ArctangentCalculatorTests
    {
        [Test]
        public void CosineCalculatorTest()
        {
            ArctangentCalculator calculator = new ArctangentCalculator();
            Assert.AreEqual(0, calculator.Calculate(0));
        }
    }
}
