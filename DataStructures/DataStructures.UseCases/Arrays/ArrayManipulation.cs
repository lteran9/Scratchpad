using System;
using DataStructures.Core;
using DataStructures.UseCases.Factory;

namespace DataStructures.UseCases.Arrays
{
   public class ArrayManipulation
   {
      /// <summary>
      /// This method will determine if the sum of two elements in a sorted array is equal to the target passed in.
      /// </summary>
      /// <param name="array">Sorted array of integers</param>
      /// <param name="target">Digit we are looking for</param>
      /// <returns></returns>
      public bool IsSumOfTwoDigitsEqualToTarget_Sorted(Core.Arrays.Array<int> array, int target)
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

      /// <summary>
      /// Given an array of integers and a key, determine if the sum of any two integers equal the key
      /// </summary>
      /// <param name="array">Unsorted array of integers</param>
      /// <param name="target">Digit we are looking for</param>
      /// <returns></returns>
      public bool IsSumOfTwoDigitsEqualToTarget_NotSorted(Core.Arrays.Array<int> array, int target)
      {
         for (int i = array.Length - 1; i > 0; i--)
         {
            for (int j = (i - 1); j >= 0; j--)
            {
               if (array[i] + array[j] == target)
               {
                  return true;
               }
            }
         }

         return false;
      }

      /// <summary>
      /// Loop through an array to find the three largest elements.
      /// </summary>
      /// <param name="arr"></param>
      /// <returns></returns> 
      public (int, int, int) GetThreeLargestElements(Core.Arrays.Array<int> arr)
      {
         // Set initial values to miminum 
         int first = int.MinValue, second = int.MinValue, third = int.MinValue;

         for (int i = 0; i < arr.Length; i++)
         {
            int element = arr[i];

            if (element > first)
            {
               third = second;
               second = first;
               first = element;
            }
            else if (element > second)
            {
               third = second;
               second = element;
            }
            else if (element > third)
            {
               third = element;
            }
         }

         return (first, second, third);
      }

      public int GetSecondLargestElement(Core.Arrays.Array<int> arr)
      {
         int first = int.MinValue, second = int.MinValue;

         for (int i = 0; i < arr.Length; i++)
         {
            int element = arr[i];

            if (element > first)
            {
               second = first;
               first = element;
            }
            else if (element > second && element != first)
            {
               second = element;
            }
         }

         return second;
      }

      public Core.Arrays.Array<int> PushZeroesToEnd(Core.Arrays.Array<int> arr)
      {
         if (arr.Length > 0)
         {
            int count = 0;
            // Put non-zero numbers first
            for (int i = 0; i < arr.Length; i++)
            {
               if (arr[i] != 0)
               {
                  arr[count] = arr[i];
                  count++;
               }
            }
            // Write out zeroes for rest of length
            while (count < arr.Length)
            {
               arr[count] = 0;
               count++;
            }
         }

         return arr;
      }

      public Core.Arrays.Array<int> RearrangeArrayInMaximumMinimumForm(Core.Arrays.Array<int> arr)
      {
         if (arr.Length > 0)
         {
            var result = new Core.Arrays.Array<int>(arr.Length);
            int leftIdx = 0, rightIdx = arr.Length - 1;

            for (int i = 0; i < arr.Length; i++)
            {
               if (i % 2 == 0)
               {
                  result[i] = arr[rightIdx];
                  rightIdx--;
               }
               else
               {
                  result[i] = arr[leftIdx];
                  leftIdx++;
               }
            }

            return result;
         }

         return arr;
      }

      public Core.Arrays.Array<int> SegregateEvenAndOdd(Core.Arrays.Array<int> arr)
      {
         if (arr.Length > 0)
         {
            var result = ArrayFactory.CreateArray<int>(arr.Length);
            int start = 0, end = arr.Length - 1;

            for (int i = 0; i < result.Length; i++)
            {
               if (arr[i] % 2 == 0)
               {
                  // Even number
                  result[start] = arr[i];
                  start++;
               }
               else
               {
                  // Odd number
                  result[end] = arr[i];
                  end--;
               }
            }

            return result;
         }

         return arr;
      }
   }
}