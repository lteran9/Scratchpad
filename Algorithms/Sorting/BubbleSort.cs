using System.Collections.Generic;

namespace Algorithms.Sorting
{
   public class BubbleSort
   {
      public static List<int> Sort(List<int> collection, SortOrder order = SortOrder.ASC)
      {
         for (int i = 0; i < collection.Count; i++)
         {
            for (int j = collection.Count - 1; j > i; j--)
            {
               if (
                  // Only perform swap if j < j - 1 and sort ascending
                  (collection[j] < collection[j - 1] && order == SortOrder.ASC)
                  ||
                  (collection[j] > collection[j - 1] && order == SortOrder.DESC)
                  // Only perform swap if j > j - 1 and sort descending
                  )
               {
                  int temp = collection[j];
                  collection[j] = collection[j - 1];
                  collection[j - 1] = temp;
               }
            }
         }

         return collection;
      }
   }
}