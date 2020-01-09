using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();

            int c = calculator.Add(1, 2);

            Assert.AreEqual(3, c);
            Assert.AreEqual(3, calculator.Result);
        }

        [TestMethod()]
        public void AddIntDoubleTest()
        {
            Calculator calculator = new Calculator();
            int a = 1;
            double b = 2.02;
            double c = calculator.Add(a, b);

            Assert.AreEqual(3.02, c);
            Assert.AreEqual(3.02, calculator.Result);
        }

        [TestMethod()]
        public void AddArrayDoubleTest()
        {
            Calculator calculator = new Calculator();
            double a = 1.01;
            double b = 2.01;
            double[] values = { a, b };

            double c = calculator.Add(values);

            Assert.AreEqual(3.02, c);
            Assert.AreEqual(3.02, calculator.Result);
        }

        [TestMethod()]
        public void AddArrayIntTest()
        {
            Calculator calculator = new Calculator();
            int[] values = { 1, 2 };

            int c = calculator.Add(values);

            Assert.AreEqual(3, c);
            Assert.AreEqual(3, calculator.Result);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();

            double c = calculator.Divide(2, 1);

            Assert.AreEqual(2, c);
            Assert.AreEqual(2, calculator.Result);
        }
    }
}