using System;
using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculater.Tests.OneArgument
{
    [TestFixture]
    public class DivisionTests
    {
        [TestCase(12, 3, 4)]
        [TestCase(9, 2, 4.5)]
        [TestCase(0, 2, 0)]

        public void CalculateTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Division();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }

        [Test]
        [ExpectedException(typeof (Exception))]
        public void DivisionTestByZero()
        {
            var calculator = new Division();
            var result = calculator.Calculate(3, 0);
        }
    }
}