
using System;
using System.Collections.Generic;
using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculater.Tests.OneArgument
{
    [TestFixture]
    public class SquareTests
    {
        [TestCase(3, 9)]
        [TestCase(0, 0)]
        [TestCase(4, 16)]

        public void CalculateTest(double argument, double result)
        {
            var calculator = new Square();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}