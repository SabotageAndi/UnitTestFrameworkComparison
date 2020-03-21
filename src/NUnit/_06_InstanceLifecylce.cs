using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;

namespace NUnitProject
{
    public class _06_InstanceLifecylce
    {
        public int _state = 0;

        [Test]
        public void TestMethod_1()
        {
            Interlocked.Increment(ref _state);

            TestContext.WriteLine($"State: {_state}");
        }

        [Test]
        public void TestMethod_2()
        {
            Interlocked.Increment(ref _state);

            TestContext.WriteLine($"State: {_state}");
        }
    }
}
