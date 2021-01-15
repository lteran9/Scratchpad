using System;
using Graphs;
using Algorithms.Search;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
   public class DFSTests
   {
      [Fact]
      public void BaseTest()
      {
         var dfs = new DFS<int>();
         var emptyList = new List<int>();
         // No elements to traverse
         Assert.Equal(emptyList, dfs.Find(0, 1));
         // Add bogey nodes and edge
         dfs.AddEdge(0, 1);
         // Target vertex does not exist
         Assert.Equal(emptyList, dfs.Find(0, 5));
      }

      [Fact]
      public void SimpleTraversalTest_Integers()
      {
         var dfs = new DFS<int>();
         dfs.AddEdge(2, 0);
         dfs.AddEdge(0, 2);
         dfs.AddEdge(0, 1);
         dfs.AddEdge(1, 2);
         dfs.AddEdge(2, 3);
         dfs.AddEdge(3, 3);

         
      }
   }
}
