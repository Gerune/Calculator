namespace Calculater.SortingOfArrays
{
    public class ShellSort : ISorting
    {
        public double[] Sort(double[] array)
        {
            {
                int step = array.Length / 2;
                while (step > 0)
                {
                    int i, j;
                    for (i = step; i < array.Length; i++)
                    {
                        double value = array[i];
                        for (j = i - step; (j >= 0) && (array[j] > value); j -= step)
                            array[j + step] = array[j];
                        array[j + step] = value;
                    }
                    step /= 2;
                }
            }
            return array;
        }
    }
}