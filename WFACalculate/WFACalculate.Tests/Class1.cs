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

        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 7)]
        [TestCase(-7, -2, -9)]
        public void CalculateAdditionTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new AdditionCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(0, 0, 0)]
        [TestCase(3, 4, -1)]
        [TestCase(-7, -2, -5)]
        public void CalculateSubtractionTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new SubtractionCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
