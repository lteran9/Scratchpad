using System;
using System.Linq;
using System.Collections.Generic;
using Graphs;

namespace Algorithms.Search
{
   /// <summary>
   /// Breadth First Search
   /// </summary>
   public class BFS<T>
   {
      public AdjacencyList<T> Graph { get; private set; }

      /// <summary>
      /// Create a new instance of the Breadth First Search algorithm.
      /// </summary>
      public BFS()
      {
         this.Graph = new AdjacencyList<T>();
      }

      /// <summary>
      /// Create a new instance of the Breadth First Search algorithm using the passed in Graph data structure.
      /// </summary>
      public BFS(AdjacencyList<T> graph)
      {
         this.Graph = graph;
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
            if (Graph.List.ContainsKey(startingVertex) && Graph.List.ContainsKey(targetVertex))
            {
               var queue = new Queue<T>();
               queue.Enqueue(startingVertex);

               while (queue.Count > 0)
               {
                  var vertex = queue.Dequeue();
                  visited.Add(vertex);

                  foreach (var neighbor in Graph.OutEdges(vertex))
                  {
                     if (!visited.Contains(neighbor) && !queue.Contains(neighbor))
                        queue.Enqueue(neighbor);
                  }

                  if (vertex.Equals(targetVertex))
                  {
                     return visited;
                  }
                  else
                  {
                     continue;
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