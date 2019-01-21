using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Program.Factorial(0), 1);
            Assert.AreEqual(Program.Factorial(1), 1);
            Assert.AreEqual(Program.Factorial(10), 3628800);
        }
    }
}
