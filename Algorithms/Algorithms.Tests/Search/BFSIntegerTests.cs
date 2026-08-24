using Algorithms.Core.Search;
using System;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Core.Tests.Search
{
    public class BFSIntegerTests
    {
        private readonly BreadthFirstSearch<int> _search = new BreadthFirstSearch<int>();

        [Fact]
        public void EmptyListTests()
        {
            var emptyList = new List<int>();
            // No elements to traverse
            Assert.Equal(emptyList, _search.Find(0, 1));
            // Add recursive node
            _search.AddEdge(100, 100);
            // Target vertex does not exist
            Assert.Equal(emptyList, _search.Find(100, 1));
        }

        [Fact]
        public void SimpleTraversalTest()
        {
            _search.AddEdge(2, 0);
            _search.AddEdge(0, 2);
            _search.AddEdge(0, 1);
            _search.AddEdge(1, 2);
            _search.AddEdge(2, 3);
            _search.AddEdge(3, 3);

            var expectedOrder = new List<int>() { 2, 0, 3, 1 };
            Assert.Equal(expectedOrder, _search.Find(2, 1));
        }
    }
}
