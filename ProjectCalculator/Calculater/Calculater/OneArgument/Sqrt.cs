using System;

namespace Calculater.OneArgument
{
    public class Sqrt : IOperation
    {
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