using System;
using System.Linq;
using System.Collections.Generic;
using Graphs;

namespace Search
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
      /// Add an Edge between Vertices to the Graph object.
      /// </summary>
      public void AddEdge(T parent, T child)
      {
         this.Graph.AddEdge(parent, child);
      }
   }
}