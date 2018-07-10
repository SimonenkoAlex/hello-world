using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WFACalculate.OperationTwoArguments;

namespace WFACalculate.Tests
{
    [TestFixture]
    public class WfaCalculateTests
    {
        [Test]
        public void AdditionCalculatorTest()
        {
            AdditionCalculator calculator = new AdditionCalculator();
            Assert.AreEqual(3, calculator.Calculate(2,1));
        }

        [Test]
        public void SubtractionCalculatorTest()
        {
            SubtractionCalculator calculator = new SubtractionCalculator();
            Assert.AreEqual(1, calculator.Calculate(2, 1));
        }

        [Test]
        public void MultiplyCalculatorTest()
        {
            MultiplyCalculator calculator = new MultiplyCalculator();
            Assert.AreEqual(20, calculator.Calculate(4, 5));
        }

        [Test]
        public void DivisionCalculatorTest()
        {
            DivisionCalculator calculator = new DivisionCalculator();
            Assert.AreEqual(4, calculator.Calculate(20, 5));
        }
    }
}
