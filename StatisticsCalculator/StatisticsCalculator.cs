using BasicCalculator;

namespace StatisticsCalculator
{
    public class StatisticsCalculator : Calculator
    {
        public double Mean(int[] values)
        {
            var sum = Add(values);
            var valueCount = values.Length;
            result = Divide(sum, valueCount);
            return result;
        }
    }
}