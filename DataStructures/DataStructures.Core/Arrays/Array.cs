using System;
using System.Runtime.InteropServices;

namespace DataStructures.Core.Arrays
{
   public class Array
   {


      public static (int, int, int) GetThreeLargestElements(int[] arr)
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

      public static int GetSecondLargestElement(int[] arr)
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

      public static int[] PushZeroesToEnd(int[] arr)
      {
         if (arr.Length > 0)
         {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
               if (arr[i] != 0)
               {
                  arr[count] = arr[i];
                  count++;
               }
            }

            while (count < arr.Length)
            {
               arr[count] = 0;
               count++;
            }
         }

         return arr;
      }

      public static int[] RearrangeArrayInMaximumMinimumForm(int[] arr)
      {
         if (arr.Length > 0)
         {
            var result = new int[arr.Length];
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

      public static int[] SegregateEvenAndOdd(int[] arr)
      {
         if (arr.Length > 0)
         {
            int[] result = new int[arr.Length];
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