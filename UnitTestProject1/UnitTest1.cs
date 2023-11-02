using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using Demo_calculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void AddTest() 
        {
            int a=1, b=2;

            int result = calculator.add(a, b);

            Assert.AreEqual(a + b, result);
        }

        [TestMethod]
        public void subtractTest()
        {
            int a = 2, b = 1;

            int result = calculator.subtract(a, b);

            Assert.AreEqual(a - b, result);
        }

        [TestMethod]
        public void DivideTest()
        {
            int a = 4, b = 1;

            int result = calculator.divide(a, b);

            Assert.AreEqual(a / b, result);
        }
    }
}
