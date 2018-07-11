using NUnit.Framework;
using WFACalculate.OperationTwoArguments;

namespace WFACalculate.Tests.OperationTwoArguments
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
    }
}
