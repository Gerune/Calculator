using System;

namespace Calculater.OneArgument
{
    public class Tg : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}