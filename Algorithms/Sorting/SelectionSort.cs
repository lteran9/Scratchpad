using System.Collections.Generic;

namespace Algorithms.Sorting
{
   public class SelectionSort
   {
      public static List<int> Sort(List<int> collection, SortOrder order = SortOrder.ASC)
      {
         int minIndex;

         for (int i = 0; i < collection.Count - 1; i++)
         {
            minIndex = i;

            // Find min value before swapping
            for (int j = i + 1; j < collection.Count; j++)
            {
               if (collection[j] < collection[minIndex])
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