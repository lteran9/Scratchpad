using System;
using DataStructures.Core.Graphs;
using Algorithms.Core.Search;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Core.Tests.Search
{
   public class DFSIntegerTests : DepthFirstSearch<int>
   {
      [Fact]
      public void EmptyListTests()
      {
         var emptyList = new List<int>();
         // No elements to traverse
         Assert.Equal(emptyList, Find(0, 1));
         // Add bogey nodes and edge
         AddEdge(0, 1);
         // Target vertex does not exist
         Assert.Equal(emptyList, Find(0, 5));
      }

      [Fact]
      public void SimpleTraversalTest()
      {
         AddEdge(2, 0);
         AddEdge(0, 2);
         AddEdge(0, 1);
         AddEdge(1, 2);
         AddEdge(2, 3);
         AddEdge(3, 3);

         var expectedOrder = new List<int>() { 2, 3, 0 };
         Assert.Equal(expectedOrder, Find(2, 1));
      }
   }
}
