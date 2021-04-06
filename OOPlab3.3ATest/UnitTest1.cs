using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPlab3._3A;
using System;

namespace OOPlab3._3ATest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BitList bit2 = new BitList(4, 3);

            Assert.IsTrue(BitList.And(bit2));
            Assert.IsTrue(BitList.Or(bit2));
            Assert.IsTrue(BitList.Not(bit2));
        }
        [TestMethod]
        public void TestMethod2()
        {
            BitList bit2 = new BitList(4, 0);
            Assert.IsFalse(BitList.And(bit2));
            Assert.IsTrue(BitList.Or(bit2));
            Assert.IsTrue(BitList.Not(bit2));
        }
        [TestMethod]
        public void TestMethod3()
        {
            BitList bit2 = new BitList(0, 0);
            Assert.IsFalse(BitList.And(bit2));
            Assert.IsFalse(BitList.Or(bit2));
            Assert.IsFalse(BitList.Not(bit2));
        }
        [TestMethod]
        public void TestMethod5()
        {
            BitList bit1 = new BitList(1, 1);
            BitList bit2 = new BitList(6, 1);
            Assert.IsTrue(bit2 != bit1);
            Assert.IsFalse(bit1 == bit2);
        }
    }
}
