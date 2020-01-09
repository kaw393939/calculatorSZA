using BasicCalculator;

namespace StatisticsCalculator
{
    public class StatisticsCalculator : Calculator
    {
        public dynamic Mean(dynamic values)
        {
            var sum = Add(values);
            var valueCount = values.Length;
            result = Divide(sum, valueCount);
            return result;
        }
    }
}