using System;
using System.Collections.Generic;
using DataStructures.UseCases.Arrays;
using DataStructures.UseCases.Factory;
using Xunit;

namespace DataStructures.Tests.ArrayTests
{
   public class InterviewQuestions
   {
      private readonly ArrayManipulation arrayFunctions = new ArrayManipulation();

      #region Easy

      [Fact]
      public void GetThreeLargestElements()
      {
         var array = ArrayFactory.CreateArray(new int[6] { 10, 4, 3, 50, 23, 90 });
         (int first, int second, int third) = arrayFunctions.GetThreeLargestElements(array);

         Assert.Equal(90, first);
         Assert.Equal(50, second);
         Assert.Equal(23, third);

         array = ArrayFactory.CreateArray(new int[8] { 6, 8, 1, 9, 2, 1, 10, 10 });

         (first, second, third) = arrayFunctions.GetThreeLargestElements(array);

         Assert.Equal(10, first);
         Assert.Equal(10, second);
         Assert.Equal(9, third);
      }

      [Fact]
      public void GetSecondLargestElement()
      {
         var array = ArrayFactory.CreateArray(new int[] { 12, 35, 1, 10, 34, -1 });
         int secondLargest = arrayFunctions.GetSecondLargestElement(array);

         Assert.Equal(34, secondLargest);
      }

      [Fact]
      public void PushZeroesToEnd()
      {
         var array = ArrayFactory.CreateArray(new int[] { 1, 2, 0, 4, 3, 0, 5, 0 });
         var output = arrayFunctions.PushZeroesToEnd(array);
         var expected = ArrayFactory.CreateArray(new int[] { 1, 2, 4, 3, 5, 0, 0, 0 });

         Assert.Equal(expected.ToString(), output.ToString());
      }

      [Fact]
      public void RearrangeArrayInMaximumMinimumForm()
      {
         var sample = ArrayFactory.CreateArray(new int[] { 1, 2, 3, 4, 5, 6, 7 });
         var output = arrayFunctions.RearrangeArrayInMaximumMinimumForm(sample);
         var expected = ArrayFactory.CreateArray(new int[] { 7, 1, 6, 2, 5, 3, 4 });

         Assert.Equal(expected.ToString(), output.ToString());
      }

      [Fact]
      public void SegregateEvenAndOdd()
      {
         var sample = ArrayFactory.CreateArray(new int[] { 7, 2, 9, 4, 6, 1, 3, 8, 5 });
         var output = arrayFunctions.SegregateEvenAndOdd(sample);
         var expected = ArrayFactory.CreateArray(new int[] { 2, 4, 6, 8, 5, 3, 1, 9, 7 });

         Assert.Equal(expected.ToString(), output.ToString());
      }

      #endregion

      #region Medium

      [Fact]
      public void ArrayPointerPractice()
      {
         // Sorted array of integers
         var array = new Core.Arrays.Array<int>(1, 2, 3, 4, 5, 6, 7, 8, 9);
         // Target 6 = 1 + 5, 2 + 4, 
         int target = 6;

         Assert.True(arrayFunctions.IsSumOfTwoDigitsEqualToTarget_Sorted(array, target));
         Assert.False(arrayFunctions.IsSumOfTwoDigitsEqualToTarget_Sorted(array, 1));

         // 15 = 7 + 8
         target = 15;

         Assert.True(arrayFunctions.IsSumOfTwoDigitsEqualToTarget_Sorted(array, target));
      }

      [Theory]
      [MemberData(nameof(ArrayWithDigitsEqualToKey))]
      public void IsSumOfTwoDigitsEqualToKey_True(Core.Arrays.Array<int> array, int key)
      {
         Assert.True(arrayFunctions.IsSumOfTwoDigitsEqualToTarget_NotSorted(array, key));
      }

      [Theory]
      [MemberData(nameof(ArrayWithNoDigitsEqualToKey))]
      public void IsSumOfTwoDigitsEqualToKey_False(Core.Arrays.Array<int> array, int key)
      {
         Assert.False(arrayFunctions.IsSumOfTwoDigitsEqualToTarget_NotSorted(array, key));
      }

      public static IEnumerable<object[]> ArrayWithDigitsEqualToKey =>
        new List<object[]>
        {
            new object[] { new Core.Arrays.Array<int>(4, 7, 3, 8, 1, 9), 11 },
            new object[] { new Core.Arrays.Array<int>(95, 5, 3, 8, 0, 4), 100 },
            new object[] { new Core.Arrays.Array<int>(2, 6, 13, 71, 3, 53), 56 },
        };

      public static IEnumerable<object[]> ArrayWithNoDigitsEqualToKey =>
        new List<object[]>
        {
            new object[] { new Core.Arrays.Array<int>(4, 7, 3, 8, 1, 9), 18 },
            new object[] { new Core.Arrays.Array<int>(95, 5, 3, 8, 0, 4), 101 },
            new object[] { new Core.Arrays.Array<int>(2, 6, 13, 71, 3, 53), 51 },
        };

      #endregion
   }
}