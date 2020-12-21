using System;
using System.Linq;
using System.Collections.Generic;

namespace Models.Graphs
{
   /// <summary>
   /// Graph Object
   /// </summary>
   public class Graph<T>
   {
      #region Members

      public List<Vertex<T>> Vertices { get; set; }
      public List<Edge<T>> Edges { get; set; }

      #endregion

      /// <summary>
      /// Create a new instance of a Graph.
      /// </summary>
      public Graph()
      {
         this.Vertices = new List<Vertex<T>>();
         this.Edges = new List<Edge<T>>();
      }

      public int GetEdgeWeight(T source, T target)
      {
         var matrix = CreateAdjacencyMatrix();

         var row = Vertices.IndexOf(new Vertex<T>(source));
         var col = Vertices.IndexOf(new Vertex<T>(target));

         if (row >= 0 && col >= 0)
         {
            return matrix[row, col];
         }

         return -1;
      }

      public bool AddVertex(T vertex)
      {
         try
         {
            // Cannot have two same vertices
            if (!this.Vertices.Any(x => x.Value.Equals(vertex)))
            {
               this.Vertices.Add(new Vertex<T>(vertex));

               return true;
            }
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return false;
      }

      public bool RemoveVertex(T vertex)
      {
         return false;
      }

      public bool AddEdge(T source, T target, int weight = 1)
      {
         try
         {
            // Make sure intended vertices exist in graph
            var startingVertex = this.Vertices.FirstOrDefault(x => x.Value.Equals(source));
            var endingVertex = this.Vertices.FirstOrDefault(x => x.Value.Equals(target));

            if (startingVertex != null && endingVertex != null)
            {
               // Make sure an existing edge is not already in the graph
               if (!this.Edges.Contains(new Edge<T>(startingVertex, endingVertex)))
               {
                  this.Edges.Add(new Edge<T>(startingVertex, endingVertex, weight));

                  return true;
               }
            }
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return false;
      }

      public bool RemoveEdge(T source, T target)
      {
         try
         {
            // Make sure intended vertices exist in graph
            var startingVertex = this.Vertices.FirstOrDefault(x => x.Value.Equals(source));
            var endingVertex = this.Vertices.FirstOrDefault(x => x.Value.Equals(target));

            if (startingVertex != null && endingVertex != null)
            {
               // If edge exists in list of edges
               if (this.Edges.Contains(new Edge<T>(startingVertex, endingVertex)))
               {
                  // Remove
                  this.Edges.Remove(new Edge<T>(startingVertex, endingVertex));

                  return true;
               }
            }
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return false;
      }

      public bool HasEdge(T source, T target)
      {
         try
         {
            // Make sure intended vertices exist in graph
            var startingVertex = this.Vertices.FirstOrDefault(x => x.Value.Equals(source));
            var endingVertex = this.Vertices.FirstOrDefault(x => x.Value.Equals(target));

            if (startingVertex != null && endingVertex != null)
            {
               // If edge exists in list of edges
               if (this.Edges.Contains(new Edge<T>(startingVertex, endingVertex)))
               {
                  return true;
               }
            }
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return false;
      }

      public List<T> GetNeighbors(T vertex)
      {
         var neighbors = new List<T>();
         var matrix = CreateAdjacencyMatrix();

         var row = this.Vertices.IndexOf(new Vertex<T>(vertex));
         for (int j = 0; j < this.Vertices.Count; j++)
         {
            if (matrix[row, j] > 0)
            {
               var item = this.Vertices[j].Value;
               neighbors.Add(item);
            }
         }

         return neighbors;
      }

      public int[,] CreateAdjacencyMatrix()
      {
         var matrix = new int[Vertices.Count, Vertices.Count];

         for (int i = 0; i < Vertices.Count; i++)
         {
            var vertex = Vertices[i];

            for (int j = 0; j < Vertices.Count; j++)
            {
               var edge = Edges.FirstOrDefault(x => x.Source.Equals(vertex) && x.Target.Equals(Vertices[j]));
               if (edge != null)
               {
                  matrix[i, j] = edge.Weight;
               }
               else
               {
                  matrix[i, j] = 0;
               }
            }
         }

         return matrix;
      }
   }
}