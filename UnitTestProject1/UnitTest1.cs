using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Korova;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 1;
            string actual = Program.CowCounter(n);
            string expected = "1 корова";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod11()
        {
            int n = 11;
            string actual = Program.CowCounter(n);
            string expected = "11 коров";
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod111()
        {
            int n = 111;
            string actual = Program.CowCounter(n);

            string expected = "111 коров";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int n = 3;
            string actual = Program.CowCounter(n);
            string expected = "3 коровы";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int n = 8;
            string actual = Program.CowCounter(n);
            string expected = "8 коров";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod0()
        {
            int n = 0;
            string actual = Program.CowCounter(n);
            string expected = "0 коров";
            Assert.AreEqual(expected, actual);
        }
    }
}
   