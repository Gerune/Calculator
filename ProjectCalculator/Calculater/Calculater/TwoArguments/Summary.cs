using System;

namespace Calculater.TwoArguments
{
    public class Summary : IOperation
    {
        public double Calculate(double firstargument, double secondargument)
        {
            return firstargument + secondargument;
        }
    }
}