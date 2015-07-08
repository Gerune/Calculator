using System;
using System.Collections.Generic;
using Calculater.OneArgument;
using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculater.Tests.OneArgument
{
    [TestFixture]
    public class TakeAwayTests
    {
        [TestCase(3, 7, -4)]
        [TestCase(0, 5, -5)]
        [TestCase(-1, 2, -3)]

        public void CalculateTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new TakeAway();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }
    }
}