using BasicCalculator;

namespace StatisticsCalculator
{
    public class StatisticsCalculator : Calculator, IStatsCalc
    {
        public dynamic Mean(dynamic values)
        {
            Result = StatOperations.StatOperations.Mean(values);
            return Result;
        }
    }
}