
using System;
using System.Collections.Generic;
using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculater.Tests.OneArgument
{
    [TestFixture]
    public class CosTests
    {
        [TestCase(0, 1)]

        public void CalculateTest(double argument, double result)
        {
            var calculator = new Cos();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}