using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace NUnitProject
{
    public class _02_TheorieAttributes
    {
        public class TheoryUsage
        {

            [Datapoint] public string Theory1 = "Test1";

            [Datapoint] public string Theory2 = "Test2";


            [Theory]
            public void TheorieTestMethod1(string parameter)
            {

            }

            [Theory]
            public void TheorieTestMethod2(string parameter)
            {

            }
        }

        public class TestCaseUsage
        {
            [TestCase("test1")]
            [TestCase("test2")]
            public void TheorieTestMethod_Inline(string parameter)
            {

            }

            [TestCaseSource(nameof(Source))]
            public void TheorieTestMethod_Separate(string parameter)
            {

            }

            private static string[] Source =
            {
                "test1",
                "test2"
            };
        }
    }
}
