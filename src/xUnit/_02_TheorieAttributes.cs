using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace xUnitProject
{

    public class _02_TheorieAttributes
    {
        [Theory]
        [InlineData("test1")]
        [InlineData("test2")]
        public void TheoryTestMethod_Inline(string parameter)
        {
        }

        [Theory]
        [MemberData(nameof(Source))]
        public void TheoryTestMethod_Member(string parameter)
        {
        }

        public static IEnumerable<object[]> Source =>
            new List<object[]>
            {
                new object[] {"test1"},
                new object[] {"test2"},
            };


    }
}
