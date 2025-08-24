using System;
using DataStructures.Core.Graphs;

namespace Algorithms.Core.Search
{
   /// <summary>
   /// Breadth First Search
   /// </summary>
   public class BreadthFirstSearch<T>
   {
      private readonly AdjacencyList<T> Graph;

      /// <summary>
      /// Create a new instance of the Breadth First Search algorithm.
      /// </summary>
      public BreadthFirstSearch()
      {
         Graph = new AdjacencyList<T>();
      }

      /// <summary>
      /// Create a new instance of the Breadth First Search algorithm using the passed in Graph data structure.
      /// </summary>
      public BreadthFirstSearch(AdjacencyList<T> graph)
      {
         Graph = graph;
      }

      /// <summary>
      /// Add an Edge between Vertices to the Graph object.
      /// </summary>
      public void AddEdge(T parent, T child)
      {
         Graph.AddEdge(parent, child);
      }

      /// <summary>
      /// Return a list of items that are connected to the starting Vertex.
      /// </summary>
      public List<T> Find(T startingVertex, T targetVertex)
      {
         var visited = new List<T>();

         try
         {
            // Validate starting and target notes are part of the graph
            if (Graph.List.ContainsKey(startingVertex) && Graph.List.ContainsKey(targetVertex))
            {
               var queue = new Queue<T>();
               queue.Enqueue(startingVertex);

               while (queue.Count > 0)
               {
                  var vertex = queue.Dequeue();
                  visited.Add(vertex);

                  if (vertex?.Equals(targetVertex) == true)
                  {
                     return visited;
                  }
                  else
                  {
                     foreach (var neighbor in Graph.OutEdges(vertex))
                     {
                        if (!visited.Contains(neighbor) && !queue.Contains(neighbor))
                        {
                           queue.Enqueue(neighbor);
                        }
                     }
                  }
               }
            }
         }
         catch (Exception ex)
         {
            Console.Out.WriteLine(ex.Message);
         }

         return visited;
      }
   }
}