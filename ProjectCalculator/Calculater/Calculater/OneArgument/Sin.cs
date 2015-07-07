using System;

namespace Calculater.OneArgument
{
    public class Sin : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}