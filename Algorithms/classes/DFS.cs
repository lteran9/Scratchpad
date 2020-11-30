using System;
using System.Linq;
using System.Collections.Generic;
using Models.Graphs;

namespace Classes.DFS
{
   public class DFS<T>
   {
      public Graph<T> Graph { get; private set; }

      public DFS()
      {
         this.Graph = new Graph<T>();
      }

      public void AddVertex(T vertex)
      {
         this.Graph.AddVertex(vertex);
      }

      public void AddEdge(T parent, T child)
      {
         this.Graph.AddEdge(parent, child);
      }

      public List<T> Find(T startingVertex)
      {
         var visited = new List<T>();

         if (this.Graph.Vertices.Any(x => x.Value.Equals(startingVertex)))
         {
            var stack = new Stack<T>();
            stack.Push(startingVertex);

            while (stack.Count > 0)
            {
               var vertex = stack.Pop();

               if (!visited.Contains(vertex))
               {
                  visited.Add(vertex);

                  foreach(var neighbor in this.Graph.GetNeighbors(vertex)) 
                  {
                     if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
                  }
               }
            }
         }

         return visited;
      }
   }
}