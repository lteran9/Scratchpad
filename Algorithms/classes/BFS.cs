using System;
using System.Linq;
using System.Collections.Generic;
using Models.Graphs;

namespace Classes.BFS
{
   /// <summary>
   /// Breadth First Search
   /// </summary>
   public class BFS<T>
   {
      public Graph<T> Graph { get; private set; }

      /// <summary>
      /// Create a new instance of the Breadth First Search algorithm.
      /// </summary>
      public BFS()
      {
         this.Graph = new Graph<T>();
      }

      /// <summary>
      /// Adds a Vertex of type T to the Graph object.
      /// </summary>
      public void AddVertex(T vertex)
      {
         this.Graph.AddVertex(vertex);
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