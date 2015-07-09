namespace Calculater.SortingOfArrays
{
    public  class InsertionSort : ISorting
    {
        public double[] Sort(double[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j;
                double buf = array[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] < buf)
                        break;

                    array[j + 1] = array[j];
                }
                array[j + 1] = buf;
            }
            return array;
        }   
    }
}