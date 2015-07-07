using System;

namespace Calculater.TwoArguments
{
    public static class TwoArgumentFactory
    {
        public static IOperation CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "Summary":
                    return new Summary();
                case "TakeAway":
                    return new TakeAway();
                case "Multiplication":
                    return new Multiplication();
                case "Division":
                    return new Division();
                case "Percent":
                    return new Percent();
                case "PowXY":
                    return new PowXY();
                default: 
                    throw new Exception();
            }
        }
    }
}