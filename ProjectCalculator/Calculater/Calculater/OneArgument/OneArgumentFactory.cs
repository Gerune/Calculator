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
                case "Sqrt":
                    return new Sqrt();
                case "Square":
                    return new Square();
                case "Gradus":
                    return new Gradus();
                case "Cos":
                    return new Cos();
                case "Tg":
                    return new Tg();
                case "DivisionByX":
                    return new DivisionByX();
                default: 
                    throw new Exception("Unknown operation");
            }
        }
    }
}