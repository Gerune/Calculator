
using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculater.Tests.OneArgument
{
    [TestFixture]
    public class TgTests
    {
        [TestCase(0, 0)]

        public void CalculateTest(double argument, double result)
        {
            var calculator = new Tg();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}