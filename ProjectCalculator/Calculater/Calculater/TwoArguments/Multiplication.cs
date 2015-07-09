namespace Calculater.TwoArguments
{
    public class Multiplication : IOperation
    {
       
        /// <summary>
        /// Function for Multiplication operation 
        /// </summary>
        /// <param name="firstargument"> multiplicand </param>
        /// <param name="secondargument"> multiplier </param>
        /// <returns> value of multiplication </returns>
        public double Calculate(double firstargument, double secondargument)
        {
            return firstargument * secondargument;
        }
    }
}