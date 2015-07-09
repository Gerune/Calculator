using System;

namespace Calculater.TwoArguments
{
    public class PowXY : IOperation
    {
        /// <summary>
        /// Function for involution opertaion
        /// </summary>
        /// <param name="firstargument"> base level </param>
        /// <param name="secondargument"> index </param>
        /// <returns> Value of involution </returns>
        public double Calculate(double firstargument, double secondargument)
        {
            return Math.Pow(firstargument, secondargument);
        }
    }
}