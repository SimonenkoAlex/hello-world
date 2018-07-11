using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    class ModuleCalculatorTests
    {
        [TestCase(26, 26)]
        [TestCase(-32, 32)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ModuleCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
