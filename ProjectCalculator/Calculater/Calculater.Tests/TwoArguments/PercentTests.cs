using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculater.Tests.OneArgument
{
    [TestFixture]
    public class PercentTests
    {
        [TestCase(100, 300, 300)]
        [TestCase(2, 100, 2)]
        [TestCase(0, 0, 0)]

        public void CalculateTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Percent();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult, 0.0000001);
        }
    }
}