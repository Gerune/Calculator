using System;

namespace Calculater.OneArgument
{
    public class DivisionByX : IOperation
    {
        /// <summary>
        /// Function for division by number
        /// </summary>
        /// <param name="argument">Number for division</param>
        /// <returns>1/argument</returns>
        public double Calculate(double argument)
        {
            if (argument == 0)
            {
                throw new Exception("division by zero");
            }
            else
            {
                return (1 / argument);
            }

        }
    }
}