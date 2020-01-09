using Add;
using Divide;

namespace BasicCalculator
{
    public class Calculator : IAdd, IDivide
    {
        // Creating objects of Geeks1 and Geeks2 class
        private readonly Adding add = new Adding();

        private readonly Div divide = new Div();

        public dynamic Result{get; set;}

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