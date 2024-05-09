using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Core.Graphs
{
   interface Graph<T>
   {
      bool AddEdge(T source, T target, decimal weight = 0);
      bool RemoveEdge(T source, T target);
      bool HasEdge(T source, T target);

      decimal GetWeight(T source, T target);

      List<T> OutEdges(T source);
      List<T> InEdges(T source);
   }
}