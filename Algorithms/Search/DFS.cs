using System;
using System.Linq;
using System.Collections.Generic;
using Graphs;

namespace Search
{
   /// <summary>
   /// Depth First Search
   /// </summary>
   public class DFS<T>
   {
      public AdjacencyList<T> Graph { get; private set; }

      /// <summary>
      /// Create a new instance of the Depth First Search algorithm.
      /// </summary>
      public DFS()
      {
         this.Graph = new AdjacencyList<T>();
      }

      /// <summary>
      /// Add an Edge between Vertices to the Graph object.
      /// </summary>
      public void AddEdge(T parent, T child)
      {
         this.Graph.AddEdge(parent, child);
      }

      /// <summary>
      /// Return a list of items that are connected to the starting Vertex.
      /// </summary>
      public List<T> Find(T startingVertex, T targetVertex)
      {
         var visited = new List<T>();

         try
         {
            if (Graph.List.ContainsKey(startingVertex))
            {
               var stack = new Stack<T>();
               stack.Push(startingVertex);

               while (stack.Count > 0)
               {
                  var vertex = stack.Pop();

                  if (vertex.Equals(targetVertex))
                  {
                     // Target vertex has been found
                     return visited;
                  }
                  else
                  {
                     // Keep looking for target vertex
                     if (!visited.Contains(vertex))
                     {
                        // Add new vertex to stack
                        visited.Add(vertex);

                        foreach (var neighbor in this.Graph.OutEdges(vertex))
                        {
                           // Add neighboring vertices to stack
                           if (!visited.Contains(neighbor))
                           {
                              stack.Push(neighbor);
                           }
                        }
                     }
                  }
               }
            }
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return visited;
      }
   }
}