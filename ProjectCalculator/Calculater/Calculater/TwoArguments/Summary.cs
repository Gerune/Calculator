namespace Calculater.TwoArguments
{
    public class Summary : IOperation
    {
        /// <summary>
        /// Functions for summary numbers
        /// </summary>
        /// <param name="firstargument"> First number </param>
        /// <param name="secondargument"> Second number </param>
        /// <returns> Result of summary </returns>
        public double Calculate(double firstargument, double secondargument)
        {
            return firstargument + secondargument;
        }
    }
}