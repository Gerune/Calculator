using System;

namespace Calculater.SortingOfArrays
{
    
    static class ArraySortingFactory
        {
        /// <summary>
        /// Factory for Array sorting
        /// </summary>
        /// <param name="operation"> Name of variant of Sorting </param>
        /// <returns> Sorting variant </returns>
   
        public static ISorting CreateSorting(string operation)
            {
                switch (operation)
                {
                    case "BubbleSort":
                        return new BubbleSort();
                        break;
                    case "InsertionSort":
                        return new InsertionSort();
                        break;
                    case "SelectionSort":
                        return new SelectionSort();
                        break;
                    case "ShellSort":
                        return new ShellSort();
                        break;
                    default:
                        throw new Exception("Unknown operation");
                }
            }
        }
    }