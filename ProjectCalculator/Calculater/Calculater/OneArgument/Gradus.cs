using System;

namespace Calculater.OneArgument
{
    public class Gradus : IOperation
    {
        /// <summary>
        /// Function for transfer gradus, from simple to radian
        /// </summary>
        /// <param name="argument"> Simple gradus number </param>
        /// <returns> Gradus(radian) </returns>
        public double Calculate(double argument)
        {
            double gradus;
            return gradus = (argument * 180) / Math.PI;
        }
    }
}