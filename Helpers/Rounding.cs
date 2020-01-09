using System;

namespace Helpers
{
    public class Rounding
    {
        public static int RoundTwoDecimalPlaces(int value)
        {
            return value;
        }

        public static double RoundTwoDecimalPlaces(double value)
        {
            return Math.Round(value, 2, MidpointRounding.ToEven);
        }
    }
}