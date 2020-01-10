using System;

namespace Helpers
{
    public class Rounding
    {
        public static double RoundNumberToDecimalPlaces(int decimalPlace, double value)
        {
            return Math.Round(value, decimalPlace, MidpointRounding.ToEven);
        }
    }
}