using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculater.Tests.OneArgument
{
    [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(3, 7, 21)]
        [TestCase(0, 5, 0)]
        [TestCase(-1, 2, -2)]

        public void CalculateTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Multiplication();
            var testResult = calculator.Calculate(firstArgument,secondArgument);
            Assert.AreEqual(result, testResult);
        }
    }
}