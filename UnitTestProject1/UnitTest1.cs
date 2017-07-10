using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Class4 sut = new Class4();

            int result = sut.Sumar(7, 5);

            Assert.AreEqual(result, 12);

        }
    }
}
