namespace Calculater.SortingOfArrays
{
    public class SelectionSort : ISorting
    {
        /// <summary>
        /// Selection sorting
        /// </summary>
        /// <param name="array"> Array for sorting </param>
        /// <returns> Sorted array </returns>
        public double[] Sort(double[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                double cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }
            return array;
        }
    }
}