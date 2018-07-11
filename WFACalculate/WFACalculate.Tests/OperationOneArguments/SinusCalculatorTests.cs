using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
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
