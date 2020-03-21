using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace NUnitProject
{
    
    public class _03_Asserts
    {
        [Test]
        public void TestMethod_Normal()
        {
            string expected = "";
            string actual = "";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMethod_CheckException()
        {
            void FunctionUnderTest()
            {
                throw new Exception();
            }

            TestDelegate testDelegate = () => FunctionUnderTest();

            Assert.Throws<Exception>(testDelegate);
        }

        [Test]
        public void TestMethod_Fail()
        {
            Assert.Fail();
        }

        [Test]
        public void TestMethod_Inconclusive()
        {
            Assert.Inconclusive();
        }
    }
}
