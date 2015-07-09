using System;

namespace Calculater.OneArgument
{
    public class Sin : IOperation
    {
        /// <summary>
        /// Function for Sinus opertaion
        /// </summary>
        /// <param name="argument"> Argument for sinus</param>
        /// <returns> Value of sinus </returns>
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}