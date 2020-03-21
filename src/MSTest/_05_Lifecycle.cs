using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject
{
    [TestClass]
    public class _05_Lifecycle
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        { }

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        { }
        
        [TestInitialize]
        public void Initialize()
        {}
        
        [TestMethod]
        public void TestMethod()
        { }

        [TestCleanup]
        public void Cleanup()
        {}

        [ClassCleanup]
        public static void ClassCleanup()
        { }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        { }

    }
}