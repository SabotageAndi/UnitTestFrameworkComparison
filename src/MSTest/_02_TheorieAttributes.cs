using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject
{
    [TestClass]
    public class _02_TheorieAttributes
    {
        [DataTestMethod()]
        [DataRow("test1")]
        [DataRow("test2")]
        public void TheorieTestMethod(string parameter)
        {

        }
    }
}
