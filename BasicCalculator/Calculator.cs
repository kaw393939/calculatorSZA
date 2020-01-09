using Add;
using Divide;

namespace BasicCalculator
{
    public class Calculator : IAdd, IDivide
    {
        // Creating objects of Geeks1 and Geeks2 class
        private Adding add = new Adding();

        private Div divide = new Div();

        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = add.Add(a, b);
            return result;
        }

        public dynamic Add(dynamic values)
        {
            result = add.Add(values);
            return result;
        }

        public double Divide(dynamic a, dynamic b)
        {
            result = divide.Divide(a, b);
            return result;
        }
    }
}