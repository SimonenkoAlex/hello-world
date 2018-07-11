using NUnit.Framework;

namespace WFACalculate.Tests.OperationTwoArguments
{
    [TestFixture]
    class MultiplyCalculatorTests
    {
        [Test]
        public void MultiplyCalculatorTest()
        {
            MultiplyCalculator calculator = new MultiplyCalculator();
            Assert.AreEqual(20, calculator.Calculate(4, 5));
        }
    }
}
