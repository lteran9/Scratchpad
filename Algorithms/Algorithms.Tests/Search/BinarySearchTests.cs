using System;
using System.Collections.Generic;
using Algorithms.Core.Search;
using Xunit;

namespace Algorithms.Core.Tests.Search
{
    public class BinarySearchTests
    {
        [Theory]
        [MemberData(nameof(LowValueSortedArray))]
        public void NeedleNotInData_Test(int[] sortedArray)
        {
            // Algorithm
            var search = new BinarySearch<int>(sortedArray);

            Assert.False(search.HasValue(10));
        }

        [Theory]
        [MemberData(nameof(LowValueSortedArray))]
        public void NeedleInData_Test(int[] sortedArray)
        {
            // Algorithm
            var search = new BinarySearch<int>(sortedArray);

            Assert.True(search.HasValue(1));
            Assert.True(search.HasValue(2));
            Assert.True(search.HasValue(3));
            Assert.True(search.HasValue(4));
            Assert.True(search.HasValue(5));
            Assert.True(search.HasValue(6));
            Assert.True(search.HasValue(7));
            Assert.True(search.HasValue(8));
            Assert.True(search.HasValue(9));
        }

        [Theory]
        [MemberData(nameof(HighValueSortedArray))]
        public void GivenSortedArray_ThenBinarySearch_AssertValuExists(int[] sortedArray)
        {
            var binarySearch = new BinarySearch<int>(sortedArray);

            Assert.True(binarySearch.HasValue(2048));
        }

        public static IEnumerable<object[]> LowValueSortedArray =>
          new List<object[]>
          {
            new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } }
          };

        public static IEnumerable<object[]> HighValueSortedArray =>
        new List<object[]>
        {
            new object[] { new int[] { 1000, 1005, 1234, 1485, 1829, 2048, 3039, 4822, 9000 } }
        };
    }
}