using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Core.Graphs
{
   /// <summary>
   /// Adjacenty List Implementation
   /// - Represents a graph using a dictionary list.
   /// </summary>
   public class AdjacencyList<T> : Graph<T>
   {
      public Dictionary<T, List<T>> List { get; private set; }

      public AdjacencyList()
      {
         List = new Dictionary<T, List<T>>();
      }

      public bool AddEdge(T source, T target, decimal weight = 0)
      {
         try
         {
            // Check if this edge already exists
            if (!HasEdge(source, target))
            {
               // If the source node isn't already part of the adjacency list add it
               if (!List.ContainsKey(source))
               {
                  List.Add(source, new List<T>() { target });
               }
               else
               {
                  // Check if the target node already exist for the source to avoid duplicate entries
                  if (!List[source].Contains(target))
                  {
                     List[source].Add(target);
                  }
               }

               return true;
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
            // Validate that the edge exists
            if (HasEdge(source, target))
            {
               // Remove target from source
               List[source].Remove(target);

               return true;
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
            return List.ContainsKey(source) && List[source].Contains(target);
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return false;
      }

      public decimal GetWeight(T source, T target)
      {
         return decimal.Zero;
      }

      public List<T> OutEdges(T source)
      {
         try
         {
            // Get the nodes connected to the source
            if (List.ContainsKey(source))
            {
               return List[source];
            }
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return new List<T>();
      }

      public List<T> InEdges(T source)
      {
         var edges = new List<T>();

         try
         {
            // Loop over all notes in the adjacency list
            foreach (var key in List.Keys)
            {
               if (List[key].Contains(source))
               {
                  // Add the nodes connected to the source
                  edges.Add(key);
               }
            }
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return edges;
      }
   }
}