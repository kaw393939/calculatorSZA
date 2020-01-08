using operations;

namespace Add
{
    public interface IAdd
    {
        public dynamic Add(dynamic a, dynamic b);

        public int Add(int[] values);

        public double Add(double[] values);
    }

    public class Adding : IAdd

    {
        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = Addition.Sum(a, b);
            return result;
        }

        public int Add(int[] values)
        {
            result = Addition.Sum(values);
            return result;
        }

        public double Add(double[] values)
        {
            result = Addition.Sum(values);
            return result;
        }
    }
}