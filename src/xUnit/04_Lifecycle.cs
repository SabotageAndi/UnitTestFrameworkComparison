
using System;
using Xunit;

namespace MSTestProject
{
    public class _04_Lifecycle : IDisposable, IClassFixture<LifecycleClassFixture>
    {
        //public static void AssemblyInitialize()
        //{ }

        public _04_Lifecycle()
        {
            //test initialization
        }
        
        
        [Fact]
        public void TestMethod()
        { }

        //public static void AssemblyCleanup()
        //{ }

        public void Dispose()
        {
            //test cleanup
        }
    }

    public class LifecycleClassFixture : IDisposable
    {
        public LifecycleClassFixture()
        {
            //class initialization
        }

        public void Dispose()
        {
            //class cleanup
        }
    }
}