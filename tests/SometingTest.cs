using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class SometingTest
    {
        [TestMethod]
        [TestCategory("Something Test")]
        public void TestMethod1()
        {
            bool expected = false;
            bool actual = false;

            Assert.AreEqual(expected, actual);
        }
    }
}
