using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    public class IntegerCollectionDataClass : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new List<int>() { } };
            yield return new object[] { new List<int>() { 0 } };
            yield return new object[] { new List<int>() { 1, 2, 3 } };
            yield return new object[] { new List<int>() { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6, 100 } };
            yield return new object[] { new List<int>() { 131, 96, 12, 808, 529, 483, 408, 324, 192, 280, 596 } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}