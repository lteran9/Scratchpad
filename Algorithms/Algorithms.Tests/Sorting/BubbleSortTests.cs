using System;
using Algorithms.Core.Sorting;
using System.Collections.Generic;
using Xunit;
using Algorithms.UseCases.Sorting;

namespace Algorithms.Tests.Sorting
{
   public class BubbleSortTests : BaseSortTest
   {
      #region TestData

      private readonly List<int> _intCollection = new List<int>() { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6, 100 };
      private readonly List<char> _charCollection = new List<char>() { 'F', 'C', 'D', 'A', 'G', '0', 'N' };

      #endregion

      [Fact]
      public void Integer_AscendingOrderTest()
      {
         var integerSort = new IntCollection(_intCollection);

         BaseAscendingTest(_intCollection, integerSort.BubbleSort);
      }

      [Fact]
      public void Integer_DescendingOrderTest()
      {
         var integerSort = new IntCollection(_intCollection, SortOrder.DESC);

         BaseDescendingTest(_intCollection, integerSort.BubbleSort);
      }

      [Fact]
      public void Character_AscendingOrderTest()
      {
         var characterSort = new CharCollection(_charCollection);

         BaseAscendingTest(_charCollection, characterSort.BubbleSort);
      }

      [Fact]
      public void Character_DescendingOrderTest()
      {
         var characterSort = new CharCollection(_charCollection, SortOrder.DESC);

         BaseDescendingTest(_charCollection, characterSort.BubbleSort);
      }
   }
}