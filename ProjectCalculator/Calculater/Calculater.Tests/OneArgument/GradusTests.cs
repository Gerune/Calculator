
using System;
using System.Collections.Generic;
using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculater.Tests.OneArgument
{
    [TestFixture]
    public class GradusTests
    {
        [TestCase(0, 0)]
        [TestCase(Math.PI/2, 90)]

        public void CalculateTest(double argument, double result)
        {
            var calculator = new Gradus();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}