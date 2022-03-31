using System.Collections.Generic;

namespace Algorithms.Sorting
{
   public class MergeSort
   {
      public static List<int> Sort(List<int> collection)
      {
         // Perform recursive sort on collection
         Sort(collection, 0, collection.Count - 1);

         return collection;
      }

      private static void Sort(List<int> collection, int left, int right)
      {
         if (right > left)
         {
            int mid = (right + left) / 2;

            Sort(collection, left, mid);
            Sort(collection, mid + 1, right);

            Merge(collection, left, mid + 1, right);
         }
      }

      private static void Merge(List<int> collection, int left, int middle, int right)
      {
         int leftEnd = (middle - 1);
         int tmpPos = left;
         int numElements = (right - left + 1);

         var temp = new int[numElements + 1];

         while ((left <= leftEnd) && (middle <= right))
         {
            if (collection[left] <= collection[middle])
            {
               temp[tmpPos++] = collection[left++];
            }
            else
            {
               temp[tmpPos++] = collection[middle++];
            }
         }

         while (left <= leftEnd)
         {
            temp[tmpPos++] = collection[left++];
         }

         while (middle <= right)
         {
            temp[tmpPos++] = collection[middle++];
         }

         for (int i = 0; i < numElements; i++)
         {
            collection[right] = temp[right];
            right--;
         }
      }
   }
}