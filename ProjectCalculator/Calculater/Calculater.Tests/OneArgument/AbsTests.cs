
using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculater.Tests.OneArgument
{
    [TestFixture]
    public class AbsTests
    {
    [TestCase(-3, 3)]
    [TestCase(0, 0)]
    [TestCase(7, 7)]
        
        public void CalculateTest(double argument, double result )
        {
            var calculator = new Abs();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result,testResult);
        }
    }
}