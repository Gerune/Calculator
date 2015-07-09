using System;

namespace Calculater.OneArgument
{
    public class Tg : IOperation
    {
        /// <summary>
        /// Function for Tangens operation 
        /// </summary>
        /// <param name="argument"> argument for tangens </param>
        /// <returns> value of tangens </returns>
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}