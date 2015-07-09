namespace Calculater.TwoArguments
{
    public class TakeAway : IOperation
    {
        /// <summary>
        /// Function for difference opertaion
        /// </summary>
        /// <param name="firstargument"> number </param>
        /// <param name="secondargument"> subtrahend </param>
        /// <returns> Value of difference opperaion </returns>
        public double Calculate(double firstargument, double secondargument)
        {
            return firstargument - secondargument;
        }
    }
}