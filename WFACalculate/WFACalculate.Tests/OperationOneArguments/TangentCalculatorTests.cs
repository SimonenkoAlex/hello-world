using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    [TestFixture]
    class TangentCalculatorTests
    {
        [Test]
        public void CosineCalculatorTest()
        {
            TangentCalculator calculator = new TangentCalculator();
            Assert.AreEqual(0, calculator.Calculate(0));
        }
    }
}
