namespace Calculater.SortingOfArrays
{
    
    public class BubbleSort : ISorting
    {
        /// <summary>
        /// Bubble sorting method
        /// </summary>
        /// <param name="a"> Array for sorting </param>
        /// <returns> Sorted array </returns>
        public double[] Sort(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[i])
                    {
                        var temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;
        }
    }
}