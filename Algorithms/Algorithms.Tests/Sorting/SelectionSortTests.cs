using System;
using Algorithms.Core.Sorting;
using System.Collections.Generic;
using Xunit;
using Algorithms.UseCases.Sorting;

namespace Algorithms.Tests.Sorting
{
   public class SelectionSortTests : BaseSortTest
   {
      #region Test Data

      private readonly List<int> _intCollection = new List<int>() { 14, 22, 23, 11, 45, 91, 2 };
      private readonly List<char> _charCollection = new List<char>() { 'F', 'C', 'D', 'A', 'G', '0', 'N' };

      #endregion

      [Fact]
      public void Integer_AscendingOrderTest()
      {
         var integerSort = new IntCollection(_intCollection);

         BaseAscendingTest(_intCollection, integerSort.SelectionSort);
      }

      [Fact]
      public void Integer_DescendingOrderTest()
      {
         var integerSort = new IntCollection(_intCollection, SortOrder.DESC);

         BaseDescendingTest(_intCollection, integerSort.SelectionSort);
      }

      [Fact]
      public void Character_AscendingOrderTest()
      {
         var characterSort = new CharCollection(_charCollection);

         BaseAscendingTest(_charCollection, characterSort.SelectionSort);
      }

      [Fact]
      public void Character_DescendingOrderTest()
      {
         var characterSort = new CharCollection(_charCollection, SortOrder.DESC);

         BaseDescendingTest(_charCollection, characterSort.SelectionSort);
      }
   }
}