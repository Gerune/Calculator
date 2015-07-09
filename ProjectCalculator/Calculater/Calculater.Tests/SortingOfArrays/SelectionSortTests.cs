using Calculater.SortingOfArrays;
using NUnit.Framework;
namespace Calculater.Tests.SortingOfArrays
{
    class SelectionSortTests : BubbleSortTests
    {
        [SetUp]
        public void Initialize()
        {
            Sorter = new SelectionSort();
        }
    }
}