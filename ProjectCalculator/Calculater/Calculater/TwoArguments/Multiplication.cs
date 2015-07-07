using System;

namespace Calculater.TwoArguments
{
    public class Multiplication : IOperation
    {
        public double Calculate(double firstargument, double secondargument)
        {
            return firstargument * secondargument;
        }
    }
}