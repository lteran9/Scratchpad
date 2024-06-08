using System;
using DataStructures.Core;

namespace DataStructures.UseCases.Arrays
{
   public class ArrayManipulation
   {
      /// <summary>
      /// This method will determine if the sum of two elements in the array is equal to the target passed in.
      /// </summary>
      /// <param name="array">Sorted array of integers</param>
      /// <param name="target">Digit we are looking for</param>
      /// <returns></returns>
      public bool IsSumOfTwoDigitsEqualToTarget(int[] array, int target)
      {
         if (array.Length > 0)
         {
            int headIndex = 0, tailIndex = array.Length - 1;

            while (headIndex < tailIndex)
            {
               var sum = array[headIndex] + array[tailIndex];

               if (sum < target)
               {
                  headIndex++;
               }
               else if (sum > target)
               {
                  tailIndex--;
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