using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
   public class MergeSort
   {
      private static SortOrder sortOrder = SortOrder.ASC;

      public static List<T> Sort<T>(List<T> collection, SortOrder order = SortOrder.ASC) where T : IComparable
      {
         sortOrder = order;

         // Perform recursive sort on collection
         return Sort(collection, 0, collection.Count - 1);
      }

      private static List<T> Sort<T>(List<T> collection, int left, int right) where T : IComparable
      {
         if (left < right)
         {
            int mid = left + (right - left) / 2;

            // Left side
            Sort(collection, left, mid);
            // Right side
            Sort(collection, mid + 1, right);

            Merge(collection, left, mid, right);
         }

         return collection;
      }

      private static void Merge<T>(List<T> collection, int left, int middle, int right) where T : IComparable
      {
         int leftArrayLen = middle - left + 1;
         int rightArrayLen = right - middle;

         var leftTempArray = new T[leftArrayLen];
         var rightTempArray = new T[rightArrayLen];

         int i, j;

         for (i = 0; i < leftArrayLen; i++)
         {
            leftTempArray[i] = collection[left + i];
         }

         for (j = 0; j < rightArrayLen; j++)
         {
            rightTempArray[j] = collection[middle + 1 + j];
         }

         i = 0;
         j = 0;
         int k = left;

         while (i < leftArrayLen && j < rightArrayLen)
         {
            if (
               (leftTempArray[i].CompareTo(rightTempArray[j]) <= 0 && sortOrder == SortOrder.ASC)
               ||
               (leftTempArray[i].CompareTo(rightTempArray[j]) > 0 && sortOrder == SortOrder.DESC)
               )
            {
               collection[k++] = leftTempArray[i++];
            }
            else
            {
               collection[k++] = rightTempArray[j++];
            }
         }

         while (i < leftArrayLen)
         {
            collection[k++] = leftTempArray[i++];
         }

         while (j < rightArrayLen)
         {
            collection[k++] = rightTempArray[j++];
         }

      }
   }
}