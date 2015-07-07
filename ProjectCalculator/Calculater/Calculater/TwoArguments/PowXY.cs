using System;

namespace Calculater.TwoArguments
{
    public class PowXY : IOperation
    {
        public double Calculate(double firstargument, double secondargument)
        {
            return Math.Pow(firstargument, secondargument);
        }
    }
}