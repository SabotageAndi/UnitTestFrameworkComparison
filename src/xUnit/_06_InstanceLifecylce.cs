using System.Threading;
using Xunit;
using Xunit.Abstractions;

namespace xUnitProject
{
    public class _06_InstanceLifecylce
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public _06_InstanceLifecylce(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        public int _state = 0;

        [Fact]
        public void TestMethod_1()
        {
            Interlocked.Increment(ref _state);

            _testOutputHelper.WriteLine($"State: {_state}");
        }

        [Fact]
        public void TestMethod_2()
        {
            Interlocked.Increment(ref _state);

            _testOutputHelper.WriteLine($"State: {_state}");
        }
    }
}
