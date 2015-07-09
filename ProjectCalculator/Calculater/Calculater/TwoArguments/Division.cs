using System;

namespace Calculater.TwoArguments
{
    public class Division : IOperation
    {
        /// <summary>
        /// Division Operation 
        /// </summary>
        /// <param name="firstArgument"> Dividend number </param>
        /// <param name="secondArgument"> Divider number </param>
        /// <returns> Value of division </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Division by zero");
            }
            else
            {
                return firstArgument / secondArgument;
            }
        }
    }
}