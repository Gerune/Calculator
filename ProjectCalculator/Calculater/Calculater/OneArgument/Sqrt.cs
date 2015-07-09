using System;

namespace Calculater.OneArgument
{
    public class Sqrt : IOperation
    {
        /// <summary>
        /// Function for Root opertaion
        /// </summary>
        /// <param name="argument"> Argument for Root </param>
        /// <returns> Value of rooted number </returns>
        public double Calculate(double argument)
        {
            if (argument < 0)
            {
                throw new Exception("sqrt by negative number");
            }
            else
            {
                return Math.Sqrt(argument);
            }

        }
    }
}