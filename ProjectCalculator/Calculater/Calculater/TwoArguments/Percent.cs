namespace Calculater.TwoArguments
{
    public class Percent : IOperation
    {
        /// <summary>
        /// Function for Percent operation
        /// </summary>
        /// <param name="firstargument"> Percent </param>
        /// <param name="secondargument"> Argument </param>
        /// <returns> Value of procent opertaion </returns>
        public double Calculate(double firstargument, double secondargument)
        {
            return (firstargument * secondargument) / 100;
        }
    }
}