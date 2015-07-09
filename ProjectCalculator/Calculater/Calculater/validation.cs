using System;

namespace Calculator.Validation
{
    public class Validator
    {
        /// <summary>
        /// Function for validation 
        /// </summary>
        /// <param name="operand"> number </param>
        /// <returns> result </returns>
        public double ValidateNumber(String operand)
        {
            double result;
            if (double.TryParse(operand, out result))
            {
                return result;
            }
                throw new Exception("Input error");
        }

    }
}