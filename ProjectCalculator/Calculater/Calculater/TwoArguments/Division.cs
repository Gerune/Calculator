using System;

namespace Calculater.TwoArguments
{
    public class Division : IOperation
    {
        public double Calculate(double firstargument, double secondargument)
        {
            return firstargument / secondargument;
        }
    }
}