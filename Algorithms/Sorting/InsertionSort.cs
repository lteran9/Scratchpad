using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
   public static class InsertionSort
   {
      public static List<T> Sort<T>(List<T> collection, SortOrder order = SortOrder.ASC) where T : IComparable
      {
         for (int i = 0; i < collection.Count - 1; i++)
         {
            for (int j = i + 1; j > 0; j--)
            {
               if (
                  (collection[j - 1].CompareTo(collection[j]) > 0 && order == SortOrder.ASC)
                  ||
                  (collection[j - 1].CompareTo(collection[j]) < 0 && order == SortOrder.DESC)
                  )
               {
                  T temp = collection[j - 1];
                  collection[j - 1] = collection[j];
                  collection[j] = temp;
               }
            }
         }

         return collection;
      }
   }
}