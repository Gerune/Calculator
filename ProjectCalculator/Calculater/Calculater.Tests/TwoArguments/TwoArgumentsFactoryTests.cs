using System;
using NUnit.Framework;

namespace Calculater.TwoArguments
{
    public class TwoArgumentsFactoryTests
    {
        [TestFixture]
        class TwoArgumetFactoryTests
        {
            [TestCase(typeof(Division), "Division")]
            [TestCase(typeof(Percent), "Percent")]
            [TestCase(typeof(PowXY), "PowXY")]
            [TestCase(typeof(Summary), "Summary")]
            [TestCase(typeof(TakeAway), "TakeAway")]
            [TestCase(typeof(Multiplication), "Multiplication")]
            public void CreateCalculator(Type expectedTypeOfOperation, string nameOfOperation)
            {
                Type resultType = TwoArgumentFactory.CreateCalculator(nameOfOperation).GetType();
                Assert.AreEqual(expectedTypeOfOperation, resultType);
            }
        }
    }
}