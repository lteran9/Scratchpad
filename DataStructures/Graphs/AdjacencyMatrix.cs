using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
   /// <summary>
   /// Adjacenty Matrix
   /// - Represents an N vertex graph using an NxN matrix.
   /// </summary>
   public class AdjacencyMatrix : Graph<Int32>
   {
      public int Nodes { get; private set; }
      public decimal[,] Matrix { get; private set; }

      public AdjacencyMatrix(int nodes)
      {
         this.Nodes = nodes;
         this.Matrix = new decimal[nodes, nodes];
      }

      public bool AddEdge(int source, int target, decimal weight = 1)
      {
         try
         {
            if (!HasEdge(source, target))
            {
               Matrix[source, target] = weight;
               Matrix[target, source] = weight;

               return true;
            }
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return false;
      }

      public bool RemoveEdge(int source, int target)
      {
         try
         {
            if (HasEdge(source, target))
            {
               Matrix[source, target] = 0;
               Matrix[target, source] = 0;

               return true;
            }
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return false;
      }

      public bool HasEdge(int source, int target)
      {
         try
         {
            return Matrix[source, target] > 0 || Matrix[target, source] > 0;
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return false;
      }

      public decimal GetWeight(int source, int target)
      {
         try
         {
            return Matrix[source, target];
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return decimal.Zero;
      }

      public List<int> OutEdges(int source)
      {
         var edges = new List<int>();

         try
         {
            for (int j = 0; j < Nodes; j++)
            {
               if (Matrix[source, j] > 0)
                  edges.Add(j);
            }
         }
         catch (Exception ex)
         {
            System.Console.Out.WriteLine(ex.Message);
         }

         return edges;
      }

      public List<int> InEdges(int source)
      {
         var edges = new List<int>();

         try
         {
            for (int j = 0; j < Nodes; j++)
            {
               if (Matrix[j, source] > 0)
                  edges.Add(j);
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