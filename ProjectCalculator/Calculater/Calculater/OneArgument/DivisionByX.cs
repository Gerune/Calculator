using System;

namespace Calculater.OneArgument
{
    public class DivisionByX : IOperation
    {
        public double Calculate(double argument)
        {
            return 1/argument;
        }
    }
}