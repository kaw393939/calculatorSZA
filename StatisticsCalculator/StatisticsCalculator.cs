﻿using BasicCalculator;
using StatOperations;
namespace StatisticsCalculator
{
    public class StatisticsCalculator : Calculator
    {
        public dynamic Mean(dynamic values)
        {
            result = StatOperations.StatOperations.Mean(values);
            return result;
        }
    }
}