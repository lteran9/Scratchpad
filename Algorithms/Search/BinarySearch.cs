using System;
using System.Collections.Generic;

namespace Algorithms.Search
{
   public class BinarySearch<T>
   {
      /// <summary>
      /// Sorted array of data values;
      /// </summary>
      private T[] Data;
      private Comparer<T> Comparer = Comparer<T>.Default;

      public BinarySearch(T[] data)
      {
         Data = data;
      }

      /// <summary>
      /// Will return true if needle is found in Data array, false otherwise.
      /// </summary>
      /// <param name="needle"></param>
      /// <returns></returns>
      public bool Find(T needle)
      {
         if (Data.Length > 0)
         {
            int low = 0, mid, high = Data.Length - 1;

            while (low <= high)
            {
               mid = (low + high) / 2;

               if (Comparer.Compare(needle, Data[mid]) < 0)
               {
                  high = mid - 1;
               }
               else if (Comparer.Compare(needle, Data[mid]) > 0)
               {
                  low = mid + 1;
               }
               else
               {
                  return true;
               }
            }
         }

         return false;
      }
   }
}