using System;
using System.Collections.Generic;
using Calculater.OneArgument;
using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculater.Tests.OneArgument
{
    [TestFixture]
    public class PowXYTests
    {
        [TestCase(3, 3, 27)]
        [TestCase(5, 0, 1)]
        [TestCase(-1, 3, -1)]

        public void CalculateTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new PowXY();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }
    }
}