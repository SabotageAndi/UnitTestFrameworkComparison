using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject
{
    [TestClass]
    public class _03_Asserts
    {
        [TestMethod]
        public void TestMethod_Normal()
        {
            string expected = "";
            string actual = "";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_CheckException()
        {
            void FunctionUnderTest()
            {
                throw new Exception();
            }

            Action functionUnderText = () => FunctionUnderTest();

            Assert.ThrowsException<Exception>(functionUnderText);
        }

        [TestMethod]
        public void TestMethod_Fail()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod_Inconclusive()
        {
            Assert.Inconclusive();
        }
    }
}
