namespace Calculater.OneArgument
{
    public class Square : IOperation
    {
        /// <summary>
        /// Function for square operation
        /// </summary>
        /// <param name="argument"> Argument whitch will be multiplaying for itself </param>
        /// <returns> Value of square number </returns>
        public double Calculate(double argument)
        {
            return argument * argument;
        }
    }
}