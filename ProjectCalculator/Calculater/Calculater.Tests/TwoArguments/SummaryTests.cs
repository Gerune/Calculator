using System;
using System.Collections.Generic;
using Calculater.OneArgument;
using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculater.Tests.OneArgument
{
    [TestFixture]
    public class SummaryTests
    {
        [TestCase(3, 7, 10)]
        [TestCase(0, 7, 7)]
        [TestCase(-1, 2, 1)]

        public void CalculateTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Summary();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }
    }
}