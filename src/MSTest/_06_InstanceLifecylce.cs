﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject
{
    [TestClass]
    public class _06_InstanceLifecylce
    {
        public TestContext TestContext { get; set; }


        public int _state = 0;


        [TestMethod]
        public void TestMethod_1()
        {
            Interlocked.Increment(ref _state);

            TestContext.WriteLine($"State: {_state}");
        }

        [TestMethod]
        public void TestMethod_2()
        {
            Interlocked.Increment(ref _state);

            TestContext.WriteLine($"State: {_state}");
        }
    }
}
