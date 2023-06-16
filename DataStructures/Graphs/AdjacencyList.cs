using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
   /// <summary>
   /// Adjacenty List
   /// - Represents a graph using a dictionary list.
   /// </summary>
   public class AdjacencyList<T> : Graph<T>
   {
      public Dictionary<T, List<T>> List { get; private set; }

      public AdjacencyList()
      {
         this.List = new Dictionary<T, List<T>>();
      }

      public bool AddEdge(T source, T target, decimal weight = 0)
      {
         try
         {
            if (!HasEdge(source, target))
            {
               if (!List.ContainsKey(source))
               {
                  List.Add(source, new List<T>() { target });
               }
               else
               {
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
            if (HasEdge(source, target))
            {
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
            foreach (var key in List.Keys)
            {
               if (List[key].Contains(source))
               {
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