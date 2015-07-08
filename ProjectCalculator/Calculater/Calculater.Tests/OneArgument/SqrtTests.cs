
using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculater.Tests.OneArgument
{
    [TestFixture]
    public class SqrtTests
    {
        [TestCase(4, 2)]
        [TestCase(9, 3)]
        [TestCase(0, 0)]

        public void CalculateTest(double argument, double result)
        {
            var calculator = new Sqrt();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
        public void SqrtTestsNegative()
        {
            var calculator = new Sqrt();
            var result = calculator.Calculate(-3);
        }
    }
}