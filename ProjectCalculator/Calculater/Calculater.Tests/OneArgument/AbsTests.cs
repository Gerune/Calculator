
using System;
using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculater.Tests.OneArgument
{
    [TestFixture]
    public class AbsTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Abs();
            var testResult = calculator.Calculate(33);
            var result = Math.Abs(33);
            Assert.AreEqual(testResult,result);
        }
    }
}