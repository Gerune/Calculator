using System;
using NUnit.Framework;

namespace Calculater.OneArgument
{
    [TestFixture]
    public class OneArgumentFactoryTests
    {
        class OneArgumetFactoryTests
        {
            [TestCase(typeof(Abs), "Abs")]
            [TestCase(typeof(Cos), "Cos")]
            [TestCase(typeof(Sin), "Sin")]
            [TestCase(typeof(DivisionByX), "DivisionByX")]
            [TestCase(typeof(Gradus), "Gradus")]
            [TestCase(typeof(Square), "Square")]
            [TestCase(typeof(Tg), "Tg")]
            [TestCase(typeof(Sqrt), "Sqrt")]
            public void CreateCalculator(Type expectedTypeOfOperation, string nameOfOperation)
            {
                Type resultType = OneArgumentFactory.CreateCalculator(nameOfOperation).GetType();
                Assert.AreEqual(expectedTypeOfOperation, resultType);
            }
        }
    }
}