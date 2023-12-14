using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using namespace isPrime;

namespace TestMethods
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(IsPrime(3));
        }

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    Assert.IsTrue(IsPrime(73));
        //}

        //[TestMethod]
        //public void TestMethod3()
        //{
        //    Assert.IsFalse(IsPrime(6));
        //}
    }
}
