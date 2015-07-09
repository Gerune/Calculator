namespace Calculater.TwoArguments
{
    public interface IOperation
    {
        /// <summary>
        /// Interface for Two arguments
        /// </summary>
        /// <param name="firstArgument"> first number </param>
        /// <param name="secondArgument"> second number </param>
        /// <returns> value of result </returns>
        double Calculate(double firstArgument, double secondArgument);
    }
}