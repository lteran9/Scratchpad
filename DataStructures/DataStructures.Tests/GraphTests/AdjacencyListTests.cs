using DataStructures.Core.Graphs;
using System;
using System.Collections.Generic;
using Xunit;

namespace DataStructures.Tests.GraphTests
{
   public class AdjacencyListTests
   {
      [Fact]
      public void BaseTest()
      {
         var list = new AdjacencyList<int>();

         // Same node count
         Assert.True(list != null);
      }

      [Fact]
      public void AddEdgeTest()
      {
         var list = new AdjacencyList<int>();

         // Add edges
         Assert.True(list.AddEdge(0, 1));
         Assert.True(list.AddEdge(1, 0));

         Assert.True(list.AddEdge(0, 2));
         Assert.True(list.AddEdge(2, 0));

         Assert.True(list.AddEdge(1, 2));
         Assert.True(list.AddEdge(2, 1));

         // Cannot add duplicate edges
         Assert.False(list.AddEdge(1, 2));
         Assert.False(list.AddEdge(2, 1));
      }

      [Fact]
      public void RemoveEdgeTest()
      {
         var list = new AdjacencyList<int>();

         list.AddEdge(0, 1);
         list.AddEdge(0, 2);
         list.AddEdge(1, 2);

         Assert.True(list.RemoveEdge(0, 1));
         Assert.True(list.RemoveEdge(0, 2));
         Assert.True(list.RemoveEdge(1, 2));
         // Cannot remove again
         Assert.False(list.RemoveEdge(0, 1));
      }

      [Fact]
      public void HasEdgeTest()
      {
         var list = new AdjacencyList<int>();

         list.AddEdge(0, 1);
         list.AddEdge(0, 2);
         list.AddEdge(1, 2);

         Assert.True(list.HasEdge(0, 1));
         Assert.True(list.HasEdge(0, 2));
         Assert.True(list.HasEdge(1, 2));
         // Out of bounds edge
         Assert.False(list.HasEdge(3, 1));
      }

      [Fact]
      public void ReflectiveEdgeTest()
      {
         var list = new AdjacencyList<int>();

         // Add edges
         Assert.True(list.AddEdge(0, 1));
         Assert.True(list.AddEdge(1, 0));

         Assert.True(list.AddEdge(0, 2));
         Assert.True(list.AddEdge(2, 0));

         Assert.True(list.AddEdge(1, 2));
         Assert.True(list.AddEdge(2, 1));

         // Has Edges
         Assert.True(list.HasEdge(1, 0));
         Assert.True(list.HasEdge(2, 0));
         Assert.True(list.HasEdge(2, 1));
      }

      [Fact]
      public void OutEdgesTest()
      {
         var list = new AdjacencyList<int>();

         list.AddEdge(0, 1);
         list.AddEdge(1, 0);
         list.AddEdge(0, 2);
         list.AddEdge(2, 0);
         list.AddEdge(1, 2);
         list.AddEdge(2, 1);

         // Outgoing Edges
         Assert.Equal(new List<int>() { 1, 2 }, list.OutEdges(0));
         Assert.Equal(new List<int>() { 0, 2 }, list.OutEdges(1));
         Assert.Equal(new List<int>() { 0, 1 }, list.OutEdges(2));
      }

      [Fact]
      public void InEdgesTest()
      {
         var list = new AdjacencyList<int>();

         list.AddEdge(0, 1);
         list.AddEdge(1, 0);
         list.AddEdge(0, 2);
         list.AddEdge(2, 0);
         list.AddEdge(1, 2);
         list.AddEdge(2, 1);

         // Incoming Edges
         Assert.Equal(new List<int>() { 1, 2 }, list.InEdges(0));
         Assert.Equal(new List<int>() { 0, 2 }, list.InEdges(1));
         Assert.Equal(new List<int>() { 0, 1 }, list.InEdges(2));

      }
   }
}
