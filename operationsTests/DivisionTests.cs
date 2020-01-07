using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            Assert.ThrowsException<DivideByZeroException>(() => Division.Quotient(a, c));
        }

        [TestMethod()]
        public void QuotientIntTest()
        {
            Assert.AreEqual(2, Division.Quotient(b, a));
        }
    }
}