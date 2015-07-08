using System;

namespace Calculater.OneArgument
{
    public class DivisionByX : IOperation
    {
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