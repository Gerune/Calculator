
using System;
using System.Collections.Generic;
using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculater.Tests.OneArgument
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(0, 0)]

        public void CalculateTest(double argument, double result)
        {
            var calculator = new Sin();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult, 0.000001);
        }
    }
}