using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace xUnitProject
{
    public class _03_Asserts
    {
        [Fact]
        public void TestMethod_Normal()
        {
            string expected = "";
            string actual = "";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMethod_CheckException()
        {
            void FunctionUnderTest()
            {
                throw new Exception();
            }

            Action testDelegate = () => FunctionUnderTest();

            Assert.Throws<Exception>(testDelegate);
        }

        [Fact]
        public void TestMethod_Fail()
        {
            throw new Exception();
        }

        [Fact]
        public void TestMethod_Inconclusive()
        {
            throw new NotImplementedException(); //can be done with https://github.com/AArnott/Xunit.SkippableFact
        }
    }
}
