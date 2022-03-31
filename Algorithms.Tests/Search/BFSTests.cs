using DataStructures.Graphs;
using Algorithms.Search;
using System;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Search
{
   public class BFSTests
   {
      [Fact]
      public void BaseTest()
      {
         var bfs = new BFS<int>();
         var emptyList = new List<int>();
         // No elements to traverse
         Assert.Equal(emptyList, bfs.Find(0, 1));
         // Add recursive node
         bfs.AddEdge(100, 100);
         // Target vertex does not exist
         Assert.Equal(emptyList, bfs.Find(100, 1));
      }

      [Fact]
      public void SimpleTraversalTest_Integers()
      {
         var bfs = new BFS<int>();
         bfs.AddEdge(2, 0);
         bfs.AddEdge(0, 2);
         bfs.AddEdge(0, 1);
         bfs.AddEdge(1, 2);
         bfs.AddEdge(2, 3);
         bfs.AddEdge(3, 3);

         var expectedOrder = new List<int>() { 2, 0, 3, 1 };
         Assert.Equal(expectedOrder, bfs.Find(2, 1));
      }

      [Fact]
      public void SimpleTraversalTest_Strings()
      {
         var bfs = new BFS<string>();
         bfs.AddEdge("C", "A");
         bfs.AddEdge("A", "C");
         bfs.AddEdge("A", "B");
         bfs.AddEdge("B", "C");
         bfs.AddEdge("C", "D");
         bfs.AddEdge("D", "D");

         var expectedOrder = new List<string>() { "C", "A", "D", "B" };
         Assert.Equal(expectedOrder, bfs.Find("C", "B"));
      }
   }
}
