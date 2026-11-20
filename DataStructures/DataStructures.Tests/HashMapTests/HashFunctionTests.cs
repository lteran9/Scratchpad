using DataStructures.Core.HashMaps;
using Xunit;

namespace DataStructures.Tests.HashMapTests
{
    public class HashFunctionTests
    {
        [Fact]
        public void HashCodesAreWithinCapacity()
        {
            var hashFunction = new HashFunction<int>();

            Assert.InRange(hashFunction.GetHashCode(-123, 10), 0, 9);
            Assert.InRange(hashFunction.CompositeHashCode(-123, 10), 0, 9);
        }
    }
}
