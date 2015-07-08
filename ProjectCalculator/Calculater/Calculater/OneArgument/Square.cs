namespace Calculater.OneArgument
{
    public class Square : IOperation
    {
        public double Calculate(double argument)
        {
            return argument * argument;
        }
    }
}