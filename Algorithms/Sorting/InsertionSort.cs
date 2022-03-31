using System.Collections.Generic;

namespace Algorithms.Sorting
{
   public class InsertionSort
   {
      public static List<int> Sort(List<int> collection)
      {
         for (int i = 0; i < collection.Count - 1; i++)
         {
            for (int j = i + 1; j > 0; j--)
            {
               if (collection[j - 1] > collection[j])
               {
                  int temp = collection[j - 1];
                  collection[j - 1] = collection[j];
                  collection[j] = temp;
               }
            }
         }

         return collection;
      }
   }
}