using operations;

namespace Divide
{
    public class Div : IDivide
    {
        public double result;

        public double Divide(dynamic a, dynamic b)
        {
            result = Division.Quotient(a, b);
            return result;
        }
    }
}