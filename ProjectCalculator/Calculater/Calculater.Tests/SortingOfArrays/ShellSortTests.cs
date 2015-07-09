using Calculater.SortingOfArrays;
using NUnit.Framework;
namespace Calculater.Tests.SortingOfArrays
{
    class ShellSortTests : BubbleSortTests
    {
        [SetUp]
        public void Initialize()
        {
            Sorter = new InsertionSort();
        }
    }
}