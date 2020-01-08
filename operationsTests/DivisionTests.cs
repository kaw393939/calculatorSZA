using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 10;
        private readonly int b = 20;
        private readonly int c = 0;

        [TestMethod()]
        public void QuotientIntDivideZeroTest()
        {
            double d = Division.Quotient(a, c);
            Assert.IsTrue(double.IsInfinity(d));
        }

        [TestMethod()]
        public void QuotientIntTest()
        {
            Assert.AreEqual(2, Division.Quotient(b, a));
        }
    }
}