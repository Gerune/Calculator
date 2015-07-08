namespace Calculater.TwoArguments
{
    public class Percent : IOperation
    {
        public double Calculate(double firstargument, double secondargument)
        {
            return (firstargument * secondargument) / 100;
        }
    }
}