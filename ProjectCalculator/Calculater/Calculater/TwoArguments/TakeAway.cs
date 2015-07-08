namespace Calculater.TwoArguments
{
    public class TakeAway : IOperation
    {
        public double Calculate(double firstargument, double secondargument)
        {
            return firstargument - secondargument;
        }
    }
}