
using System;
using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculater.Tests.OneArgument
{
    [TestFixture]
    public class DivisionByXTests
    {
        [TestCase(5, 0.2 )]
        [TestCase(-2, -0.5)]
        [TestCase(1, 1)]

        public void CalculateTest(double argument, double result)
        {
            var calculator = new DivisionByX();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
        [Test]
        [ExpectedException(typeof(Exception))]
        public void DivisionTestByXAsZero()
        {
            var calculator = new DivisionByX();
            calculator.Calculate(0);
        }
    }
}