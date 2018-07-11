using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    [TestFixture]
    class NegativeCalculatorTests
    {
        [Test]
        public void SinusCalculatorTest()
        {
            NegativeCalculator calculator = new NegativeCalculator();
            Assert.AreEqual(-30, calculator.Calculate(30));
        }
    }
}
