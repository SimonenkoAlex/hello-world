using NUnit.Framework;

namespace WFACalculate.Tests.OperationOneArgumentsTests
{
    [TestFixture]
    class SinusCalculatorTests
    {
        [Test]
        public void SinusCalculatorTest()
        {
            SinusCalculator calculator = new SinusCalculator();
            Assert.AreEqual(0, calculator.Calculate(0));
        }
    }
}
