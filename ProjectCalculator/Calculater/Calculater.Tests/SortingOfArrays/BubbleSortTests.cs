using System;
using Calculater.SortingOfArrays;
using NUnit.Framework;

namespace Calculater.Tests.SortingOfArrays
{
    [TestFixture]
    public abstract class BubbleSortTests
    {
        protected ISorting Sorter;

        [TestCase(new[] {15, -3, 14, 7, 0.0, -34}, new[] {-34, -3, 0.0, 7, 14, 15})]
        [TestCase(new[] {15, 77, 114, -3.4, 100, 78}, new[] {-3.4, 15, 77, 78, 100, 114})]
        [TestCase(new[] {0.0, 2, 14, 7, 43, 75, 112, 150, -21, -34, 5, 17, 21, 100.3, 170, 89},
           new[] {-34, -21, 0.0, 2,5, 7, 14, 17, 21, 43, 75, 89, 100.3, 112, 150, 170})]
        public void Sort(double[] argument, double[] result)
        {
            var testResult = Sorter.Sort(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}