using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
   public class BubbleSort<T> where T : IComparable
   {
      public List<T> Sort(List<T> collection, SortOrder order = SortOrder.ASC)
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