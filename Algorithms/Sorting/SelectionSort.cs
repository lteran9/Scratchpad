using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
   public class SelectionSort
   {
      public static List<T> Sort<T>(List<T> collection, SortOrder order = SortOrder.ASC) where T : IComparable
      {
         int minIndex;

         for (int i = 0; i < collection.Count - 1; i++)
         {
            minIndex = i;

            // Find min value before swapping
            for (int j = i + 1; j < collection.Count; j++)
            {
               if (
                  (collection[j].CompareTo(collection[minIndex]) < 0 && order == SortOrder.ASC)
                  ||
                  (collection[j].CompareTo(collection[minIndex]) > 0 && order == SortOrder.DESC)
                  )
               {
                  minIndex = j;
               }
            }

            // If min index differs make swap
            if (minIndex != i)
            {
               var temp = collection[i];
               collection[i] = collection[minIndex];
               collection[minIndex] = temp;
            }
         }

         return collection;
      }
   }
}