using System;

namespace Calculater.OneArgument
{
    public class Cos : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}