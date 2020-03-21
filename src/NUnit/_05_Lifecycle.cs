

using NUnit.Framework;


[SetUpFixture]
public class AssemblyLifecylce
{
    [OneTimeSetUp]
    public static void AssemblyInitialize()
    { }

    [OneTimeTearDown]
    public static void AssemblyCleanup()
    { }
}


namespace NUnitProject
{
    public class _05_Lifecycle
    {
        [OneTimeSetUp]
        public void ClassInitialize()
        { }

        [SetUp]
        public void Initialize()
        { }

        [Test]
        public void TestMethod()
        { }

        [TearDown]
        public void Cleanup()
        { }

        [OneTimeTearDown]
        public void ClassCleanup()
        { }
    }
}