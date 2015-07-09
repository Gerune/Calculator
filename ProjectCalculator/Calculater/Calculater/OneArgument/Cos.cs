using System;

namespace Calculater.OneArgument
{
    public class Cos : IOperation
    {
       /// <summary>
       /// function for Cosinus operation
       /// </summary>
       /// <param name="argument">Argument for Cosinus</param>
       /// <returns> Value of Cosinus </returns>
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}