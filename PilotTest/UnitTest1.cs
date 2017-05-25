using System;
using Pilot.Lib;
using Xunit;

namespace PilotTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var instance = new DummyLib();
            var result = instance.Sum(10, 5);
            Assert.Equal(15, result);
        }
    }
}
