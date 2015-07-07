using System;

namespace Calculater.OneArgument
{
    public static class OneArgumentFactory
    {
        public static IOperation CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "Sin": 
                    return new Sin();
                case "Abs": 
                    return new Abs();
                default: 
                    throw new Exception("Unknown operation");
            }
        }
    }
}