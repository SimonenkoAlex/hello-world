using System;
using NUnit.Framework;
using WFACalculate.OperationOneArguments;

namespace WFACalculate.Tests.OperationOneArguments
{
    class OneArgumentsFactoryTests
    {
        [TestCase("Sinus", typeof(SinusCalculator))]
        [TestCase("Logarithm", typeof(LogarithmCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
