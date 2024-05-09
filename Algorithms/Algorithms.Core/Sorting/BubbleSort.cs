using System;
using System.Collections.Generic;

namespace Algorithms.Core.Sorting
{
   public static class BubbleSort
   {
      public static List<T> Sort<T>(List<T> collection, SortOrder order = SortOrder.ASC) where T : IComparable
      {
         for (int i = 0; i < collection.Count; i++)
         {
            for (int j = collection.Count - 1; j > i; j--)
            {
               if (
                  (collection[j].CompareTo(collection[j - 1]) < 0 && order == SortOrder.ASC)
                  ||
                  (collection[j].CompareTo(collection[j - 1]) > 0 && order == SortOrder.DESC)
                  )
               {
                  T temp = collection[j];
                  collection[j] = collection[j - 1];
                  collection[j - 1] = temp;
               }
            }
         }

         return collection;
      }
   }
}