using System;
using Xunit;

namespace MhLabs.Cryptography.Tests
{
    public class HashUtilityTests
    {
        [Fact]
        public void HashTest()
        {
            var str = "123456";
            var hashed = HashUtility.Compute(str);
        }
    }
}
