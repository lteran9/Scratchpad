using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    public class StringCollectionDataClass : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new List<string>() { } };
            yield return new object[] { new List<string>() { "Distro" } };
            yield return new object[] { new List<string>() { "Apple", "Banana", "Cherry" } };
            yield return new object[] { new List<string>() { "Zebra", "Apple", "Mango", "Banana", "Cherry", "Date", "Orange" } };
            yield return new object[] { new List<string>() { "Dog", "Cat", "Bird", "Ant", "Elephant", "Fish" } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
