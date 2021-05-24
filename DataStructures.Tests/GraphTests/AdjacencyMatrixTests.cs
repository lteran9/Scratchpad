using DataStructures.Graphs;
using System;
using System.Collections.Generic;
using Xunit;

namespace DataStructures.GraphTests
{
   public class AdjacencyMatrixTests
   {
      [Fact]
      public void BaseTest()
      {
         var matrix = new AdjacencyMatrix(3);

         // Same node count
         Assert.True(matrix.Nodes == 3);
      }

      [Fact]
      public void AddEdgeTest()
      {
         var matrix = new AdjacencyMatrix(3);

         // Add edges
         Assert.True(matrix.AddEdge(0, 1));
         Assert.True(matrix.AddEdge(0, 2));
         Assert.True(matrix.AddEdge(1, 2));

         // Cannot add duplicate edges
         Assert.False(matrix.AddEdge(1, 2));
      }

      [Fact]
      public void RemoveEdgeTest()
      {
         var matrix = new AdjacencyMatrix(3);

         matrix.AddEdge(0, 1);
         matrix.AddEdge(0, 2);
         matrix.AddEdge(1, 2);

         Assert.True(matrix.RemoveEdge(0, 1));
         Assert.True(matrix.RemoveEdge(0, 2));
         Assert.True(matrix.RemoveEdge(1, 2));
         // Cannot remove again
         Assert.False(matrix.RemoveEdge(0, 1));
      }

      [Fact]
      public void HasEdgeTest()
      {
         var matrix = new AdjacencyMatrix(3);

         matrix.AddEdge(0, 1);
         matrix.AddEdge(0, 2);
         matrix.AddEdge(1, 2);

         Assert.True(matrix.HasEdge(0, 1));
         Assert.True(matrix.HasEdge(0, 2));
         Assert.True(matrix.HasEdge(1, 2));
         // Out of bounds edge
         Assert.False(matrix.HasEdge(3, 1));
      }

      [Fact]
      public void ReflectiveEdgeTest()
      {
         var matrix = new AdjacencyMatrix(3);

         // Add edges
         Assert.True(matrix.AddEdge(0, 1));
         Assert.True(matrix.AddEdge(0, 2));
         Assert.True(matrix.AddEdge(1, 2));

         // Has Edges
         Assert.True(matrix.HasEdge(1, 0));
         Assert.True(matrix.HasEdge(2, 0));
         Assert.True(matrix.HasEdge(2, 1));
      }

      [Fact]
      public void OutEdgesTest()
      {
         var matrix = new AdjacencyMatrix(3);

         matrix.AddEdge(0, 1);
         matrix.AddEdge(0, 2);
         matrix.AddEdge(1, 2);

         // Outgoing Edges
         Assert.Equal(new List<int>() { 1, 2 }, matrix.OutEdges(0));
         Assert.Equal(new List<int>() { 0, 2 }, matrix.OutEdges(1));
         Assert.Equal(new List<int>() { 0, 1 }, matrix.OutEdges(2));
      }

      [Fact]
      public void InEdgesTest()
      {
         var matrix = new AdjacencyMatrix(3);

         matrix.AddEdge(0, 1);
         matrix.AddEdge(0, 2);
         matrix.AddEdge(1, 2);

         // Incoming Edges
         Assert.Equal(new List<int>() { 1, 2 }, matrix.InEdges(0));
         Assert.Equal(new List<int>() { 0, 2 }, matrix.InEdges(1));
         Assert.Equal(new List<int>() { 0, 1 }, matrix.InEdges(2));

      }
   }
}
