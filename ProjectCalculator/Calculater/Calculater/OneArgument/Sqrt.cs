using System;

namespace Calculater.OneArgument
{
    public class Sqrt : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Sqrt(argument);
        }
    }
}