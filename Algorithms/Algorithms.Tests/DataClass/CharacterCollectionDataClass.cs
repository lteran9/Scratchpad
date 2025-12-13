using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    public class CharacterCollectionDataClass : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new List<char>() { } };
            yield return new object[] { new List<char>() { 'A', } };
            yield return new object[] { new List<char>() { 'A', 'B', 'C' } };
            yield return new object[] { new List<char>() { 'F', 'C', 'D', 'A', 'G', '0', 'N' } };
            yield return new object[] { new List<char>() { 'A', 'Z', 'B', 'Y', 'C', 'W', 'D', 'X' } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}