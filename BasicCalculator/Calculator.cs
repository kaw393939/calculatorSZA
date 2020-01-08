using operations;
using Add;
using Divide;

namespace BasicCalculator
{
    public interface ICalcultorBasic
    {
        public dynamic Add(dynamic a, dynamic b);
        public dynamic Divide(dynamic a, dynamic b);

    }

    public class Calculator : IAdd, IDivide
    {
        // Creating objects of Geeks1 and Geeks2 class 
        Adding add = new Adding();
        Div divide = new Div();
        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = add.Add(a, b);
            return result;
        }

        public dynamic Divide(dynamic a, dynamic b)
        {
            result = divide.Divide(a, b);
            return result;

        }

    }
}