using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject
{
    [TestClass]
    public class _04_Output
    {
        public TestContext TestContext { get; set; }


        [TestMethod]
        public void TestMethod()
        {
            TestContext.WriteLine("Output");
        }
    }
}
