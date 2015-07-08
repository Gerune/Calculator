namespace Calculater.SortingOfMassives
{
    public class SelectionSort : ISorting
    {
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