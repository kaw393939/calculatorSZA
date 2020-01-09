using Add;
using Divide;

namespace BasicCalculator
{
    public class Calculator : IAdd, IDivide
    {
        private readonly Adding add = new Adding();
        private readonly Div divide = new Div();
        private dynamic result;

        public dynamic Result
        {
            get
            {
                string type = result.GetType().ToString();

                if (type == "Int")
                {
                    return result;
                }
                else
                {
                    return Helpers.Rounding.RoundTwoDecimalPlaces(result);
                }
            }
            set
            {
                result = value;
            }
        }

        public dynamic Add(dynamic a, dynamic b)
        {
            Result = add.Add(a, b);
            return Result;
        }

        public dynamic Add(dynamic values)
        {
            Result = add.Add(values);
            return Result;
        }

        public double Divide(dynamic a, dynamic b)
        {
            Result = divide.Divide(a, b);
            return Result;
        }
    }
}