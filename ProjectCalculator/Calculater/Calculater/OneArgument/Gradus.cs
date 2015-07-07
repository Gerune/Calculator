using System;

namespace Calculater.OneArgument
{
    public class Gradus : IOperation
    {
        public double Calculate(double argument)
        {
            double gradus;
            return gradus = (argument * 180) / Math.PI;
        }
    }
}