using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DataStructures.Graphs
{
   /// <summary>
   /// Adjacenty Matrix Implementation
   /// - Represents an N vertex graph using an NxN matrix.
   /// </summary>
   public class AdjacencyMatrix<T> : Graph<T>
   {
      public int NumberOfNodes { get; private set; }
      public decimal[,] Matrix { get; private set; }
      public Dictionary<T, int> LookUpTable { get; private set; }

      private int index { get; set; }

      public AdjacencyMatrix(int nodes)
      {
         this.NumberOfNodes = nodes;
         this.LookUpTable = new Dictionary<T, int>();
         this.Matrix = new decimal[nodes, nodes];
         this.index = 0;
      }

      public bool AddEdge(T source, T target, decimal weight = 1)
      {
         try
         {
            if (LookUpTable.ContainsKey(source) == false)
            {
               LookUpTable.Add(source, index++);
            }
            if (LookUpTable.ContainsKey(target) == false)
            {
               LookUpTable.Add(target, index++);
            }
            if (!HasEdge(source, target))
            {
               Matrix[LookUpTable[source], LookUpTable[target]] = weight;
               Matrix[LookUpTable[target], LookUpTable[source]] = weight;

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
               Matrix[LookUpTable[source], LookUpTable[target]] = 0;
               Matrix[LookUpTable[target], LookUpTable[source]] = 0;

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
            return Matrix[LookUpTable[source], LookUpTable[target]] > 0 || Matrix[LookUpTable[target], LookUpTable[source]] > 0;
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return false;
      }

      public decimal GetWeight(T source, T target)
      {
         try
         {
            return Matrix[LookUpTable[source], LookUpTable[target]];
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return decimal.Zero;
      }

      public List<T> OutEdges(T source)
      {
         var edges = new List<T>();

         try
         {
            for (int j = 0; j < NumberOfNodes; j++)
            {
               if (Matrix[LookUpTable[source], j] > 0)
               {
                  edges.Add(LookUpTable.Keys.ToArray()[j]);
               }
            }
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return edges;
      }

      public List<T> InEdges(T source)
      {
         var edges = new List<T>();

         try
         {
            for (int i = 0; i < NumberOfNodes; i++)
            {
               if (Matrix[i, LookUpTable[source]] > 0)
               {
                  edges.Add(LookUpTable.Keys.ToArray()[i]);
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