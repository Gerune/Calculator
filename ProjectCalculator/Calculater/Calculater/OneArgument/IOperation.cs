namespace Calculater.OneArgument
{
    public interface IOperation
    {
        /// <summary>
        /// Function For calculate opertaions
        /// </summary>
        /// <param name="argument"> Argument for opertaions </param>
        /// <returns></returns>
        double Calculate(double argument);
    }
}