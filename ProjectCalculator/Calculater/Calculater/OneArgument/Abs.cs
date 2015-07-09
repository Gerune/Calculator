using System;

namespace Calculater.OneArgument
{
    public class Abs : IOperation
    {
        /// <summary>
        /// Function for "Absolute Number" operation
        /// </summary>
        /// <param name="argument"></param>
        /// <returns> Value of Absolute number </returns>
        public double Calculate(double argument)
        {
            return Math.Abs(argument);
        }
    }
}