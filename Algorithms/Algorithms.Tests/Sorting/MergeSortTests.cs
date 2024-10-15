using System;
using Algorithms.Core.Sorting;
using System.Collections.Generic;
using Xunit;
using Algorithms.UseCases.Sorting;

namespace Algorithms.Tests.Sorting
{
   public class MergeSortTests : BaseSortTest
   {
      #region TestData 

      private readonly List<int> _intCollection = new List<int>() { 32, 11, 857, 23, 9, 0, 333 };
      private readonly List<char> _charCollection = new List<char>() { 'Q', 'P', '<', '.', '1', 'T', '+' };

      #endregion

      [Fact]
      public void Integer_AscendingOrderTest()
      {
         var integerSort = new IntCollection(_intCollection);

         BaseAscendingTest(_intCollection, integerSort.MergeSort);
      }

      [Fact]
      public void Integer_DescendingOrderTest()
      {
         var integerSort = new IntCollection(_intCollection, SortOrder.DESC);

         BaseDescendingTest(_intCollection, integerSort.MergeSort);
      }

      [Fact]
      public void Character_AscendingOrderTest()
      {
         var characterSort = new CharCollection(_charCollection);

         BaseAscendingTest(_charCollection, characterSort.MergeSort);
      }

      [Fact]
      public void Character_DescendingOrderTest()
      {
         var characterSort = new CharCollection(_charCollection, SortOrder.DESC);

         BaseDescendingTest(_charCollection, characterSort.MergeSort);
      }
   }
}