using System;
using System.Linq;
using Xunit;
using Models.Graphs;

namespace DataStructures.Tests.GraphTests
{
   public class GraphTests1
   {
      [Fact]
      public void VertexTests()
      {
         var graph = new Graph<int>();

         // Members initialized
         Assert.True(graph.Vertices.Count == 0);
         Assert.True(graph.Edges.Count == 0);

         // Add vertices; cannot have duplicate vertex
         Assert.True(graph.AddVertex(1));
         Assert.False(graph.AddVertex(1));
         Assert.True(graph.AddVertex(2));
         Assert.True(graph.AddVertex(3));

         // Count vertices
         Assert.True(graph.Vertices.Count == 3);
      }

      [Fact]
      public void EdgeTests()
      {
         var graph = new Graph<string>();

         // Add starting vertices
         Assert.True(graph.AddVertex("A"));
         Assert.True(graph.AddVertex("B"));
         Assert.True(graph.AddVertex("C"));
         Assert.True(graph.AddVertex("E"));

         // Add starting edges
         Assert.True(graph.AddEdge("A", "B"));
         Assert.True(graph.AddEdge("B", "C"));
         Assert.True(graph.AddEdge("B", "E"));
         Assert.False(graph.AddEdge("B", "E"));

         // Do not add repeated edges
         Assert.True(graph.Edges.Count == 3);

         // Simple directed graph
         Assert.Contains(graph.Edges, x => x.Parent.Value == "A" && x.Child.Value == "B");
         Assert.Contains(graph.Edges, x => x.Parent.Value == "B" && x.Child.Value == "C");
         Assert.Contains(graph.Edges, x => x.Parent.Value == "B" && x.Child.Value == "E");
      }

      [Fact]
      public void WeightedEdgeTests()
      {
         var graph = new Graph<int>();

         Assert.True(graph.AddVertex(1));
         Assert.True(graph.AddVertex(3));
         Assert.True(graph.AddVertex(5));
         Assert.True(graph.AddVertex(7));
         Assert.True(graph.AddVertex(11));

         Assert.True(graph.AddEdge(1, 3, 3));
         Assert.True(graph.AddEdge(3, 5, 2));
         Assert.True(graph.AddEdge(1, 7, 9));
         Assert.True(graph.AddEdge(7, 11, 1));

         Assert.Equal(3, graph.GetEdgeWeight(1, 3));
         Assert.Equal(2, graph.GetEdgeWeight(3, 5));
         Assert.Equal(9, graph.GetEdgeWeight(1, 7));
         Assert.Equal(1, graph.GetEdgeWeight(7, 11));
         Assert.Equal(0, graph.GetEdgeWeight(3, 11));
      }

      [Fact]
      public void AdjacencyMatrixTests()
      {
         
      }
   }
}
