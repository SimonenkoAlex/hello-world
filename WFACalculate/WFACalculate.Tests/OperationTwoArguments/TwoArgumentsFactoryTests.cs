using System;
using NUnit.Framework;
using WFACalculate.OperationTwoArguments;

namespace WFACalculate.Tests.OperationTwoArguments
{
    class TwoArgumentsFactoryTests
    {
        [TestCase("Addition", typeof(AdditionCalculator))]
        [TestCase("Subtraction", typeof(SubtractionCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
